using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading;
using FontAwesome.Sharp;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using MaterialSkinExample.Properties;

namespace JBWMLauncher {
	public partial class LauncherForm : MaterialForm {

		private Color primary = Color.FromArgb(63, 81, 181);
		private Color error = Color.Crimson;


		private static readonly HttpClient client = new HttpClient();
		System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

		private bool online = false;

		private readonly MaterialSkinManager materialSkinManager;
		public LauncherForm() {
			InitializeComponent();

			materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, 
				Primary.Indigo100, Accent.Pink200, TextShade.WHITE);

			premium.Checked = Settings.Default.premium;
			darkTheme.Checked = Settings.Default.darkTheme;
			fullScreen.Checked = Settings.Default.fullScreen;

			ramUsage.Text = Settings.Default.maxRamUsage;

			windowWidth.Text = Settings.Default.windowWidth.ToString();
			windowHeight.Text = Settings.Default.windowHeight.ToString();

			premiumFormController();

			status.Image = IconChar.CircleNotch.ToBitmap(32, primary, 200);

			materialSkinManager.Theme = Settings.Default.darkTheme ?
				MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;

			Thread thread = new Thread(CStatus);
			thread.Start();

			timer.Interval = 1;
			timer.Tick += DisplayTicker;
			timer.Start();

		}

		private async void DisplayTicker(object sender, EventArgs e) {
			var delta = 19.0 * timer1.Interval / 1000.0;
			status.Rotation += delta;
		}

		private void CStatus() {
			try {
				var responseString = client.GetStringAsync("https://api.mcsrvstats.us/2/35.198.89.80");
				JObject jsonResponse = JObject.Parse(responseString.Result);

				online = (bool)jsonResponse["debug"]["ping"];

			} catch(Exception) {
				online = false;
			}

			status.Image = online ? IconChar.Check.ToBitmap(32, Color.Lime) :
						IconChar.Times.ToBitmap(32, error);
			status.Rotation = 0;
			timer.Stop();

		}
		
		private void ApplicationExit() {
			Process.GetCurrentProcess().Kill();
			Application.Exit();
		}


		private void darkTheme_CheckedChanged(object sender, EventArgs e) {
			materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ?
				(MaterialSkinManager.Themes.LIGHT) : MaterialSkinManager.Themes.DARK;

			validText.ForeColor = error;
		}

		private void premium_CheckedChanged(object sender, EventArgs e) {
			Settings.Default.premium = premium.Checked;
			Settings.Default.Save();

			premiumFormController();
		}

		private void premiumFormController() {
			if(premium.Checked) {
				online = true;
				passwordForm.Enabled = true;
				usernameForm.Hint = "Adres email";
			} else {
				usernameForm.Hint = "Nazwa użytkownika";
				passwordForm.Enabled = false;
				online = false;
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			ApplicationExit();
		}

		private void close_Click(object sender, EventArgs e) {
			ApplicationExit();
		}

		private bool isNumeric(string str) {
			if(int.TryParse(str, out _)) {
				return true;
			}
			return false;
		}


		private void join_Click(object sender, EventArgs e) {
			MainLauncher();
		}

		private void MainLauncher() {
			var credentials = new {
				username = usernameForm.Text,
				password = passwordForm.Text
			};

			validText.Text = "";

			var minecraftDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
			var libraries = Path.Combine(minecraftDir, "libraries")

			if(premium.Checked) {
				if(credentials.username != "" && credentials.password != "") {
					MojangApi auth = new MojangApi();

					var task = auth.getAccesToken(credentials.username, credentials.password);
					task.Wait();

					Debug.WriteLine(task.Result);


					if(task.Result) {
						return;
					} else {
						validText.Text = "Niepoprawne dane logowania.";
						validText.ForeColor = error;

						return;
					}
				}

				validText.Text = "Prosimy wypełnić wszystkie pola.";
				validText.ForeColor = error;

				return;
			} else {
				if(credentials.username != "") {
					GameClient gc = new GameClient();

					gc.run_online();
					
					return;

				}

				validText.Text = "Prosimy wypełnić wszystkie pola.";
				validText.ForeColor = error;

				return;
			}
		}

		private void fullScreen_CheckedChanged(object sender, EventArgs e) {
			Settings.Default.fullScreen = fullScreen.Checked;
		}

		private void saveButton_Click(object sender, EventArgs e) {
			resolutionError.Text = "";
			ramError.Text = "";

			var endString = ramUsage.Text.Substring(ramUsage.Text.Length - 2).ToUpper();
			bool isValidForm = true;

			Settings.Default.darkTheme = darkTheme.Checked;

			if(!(isNumeric(windowWidth.Text) && isNumeric(windowHeight.Text))) {
				resolutionError.Text = "Niepoprawna rozdzielczość";
				resolutionError.ForeColor = error;

				isValidForm = false;
			}

			if(!(endString == "MB" || endString == "GB")) {
				ramError.Text = "Wprowadzono niepoprawne dane";
				ramError.ForeColor = error;

				isValidForm = false;
			}

			if(isValidForm) {
				Settings.Default.windowWidth = int.Parse(windowWidth.Text);
				Settings.Default.windowHeight = int.Parse(windowHeight.Text);
				Settings.Default.maxRamUsage = ramUsage.Text;

				success.Text = "Ustawienia zostały pomyślnie zapisane";
				success.ForeColor = Color.LimeGreen;

				Settings.Default.Save();
			}
		}
	}
}
