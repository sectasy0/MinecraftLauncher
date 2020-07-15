using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using FontAwesome.Sharp;

namespace JBWMLauncher {
    partial class LauncherForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.close = new MaterialSkin.Controls.MaterialFlatButton();
            this.join = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.settings = new System.Windows.Forms.TabPage();
            this.saveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ramError = new MaterialSkin.Controls.MaterialLabel();
            this.fullScreen = new MaterialSkin.Controls.MaterialCheckBox();
            this.windowHeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.windowWidth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.windowResolution = new MaterialSkin.Controls.MaterialLabel();
            this.ramUsageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ramUsage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.darkTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.login = new System.Windows.Forms.TabPage();
            this.onlinePlayers = new MaterialSkin.Controls.MaterialLabel();
            this.status = new FontAwesome.Sharp.IconPictureBox();
            this.validText = new MaterialSkin.Controls.MaterialLabel();
            this.premium = new MaterialSkin.Controls.MaterialCheckBox();
            this.passwordForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameForm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resolutionError = new MaterialSkin.Controls.MaterialLabel();
            this.success = new MaterialSkin.Controls.MaterialLabel();
            this.settings.SuspendLayout();
            this.login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.close.AutoSize = true;
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.Depth = 0;
            this.close.Icon = null;
            this.close.Location = new System.Drawing.Point(14, 369);
            this.close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.close.MouseState = MaterialSkin.MouseState.HOVER;
            this.close.Name = "close";
            this.close.Primary = false;
            this.close.Size = new System.Drawing.Size(80, 36);
            this.close.TabIndex = 13;
            this.close.Text = "Zamknij";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // join
            // 
            this.join.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.join.AutoSize = true;
            this.join.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.join.Depth = 0;
            this.join.ForeColor = System.Drawing.SystemColors.ControlText;
            this.join.Icon = null;
            this.join.Location = new System.Drawing.Point(472, 369);
            this.join.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.join.MouseState = MaterialSkin.MouseState.HOVER;
            this.join.Name = "join";
            this.join.Primary = true;
            this.join.Size = new System.Drawing.Size(129, 36);
            this.join.TabIndex = 1;
            this.join.Text = "Dołącz do gry!";
            this.join.UseVisualStyleBackColor = true;
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 362);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(625, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.White;
            this.settings.Controls.Add(this.success);
            this.settings.Controls.Add(this.resolutionError);
            this.settings.Controls.Add(this.saveButton);
            this.settings.Controls.Add(this.ramError);
            this.settings.Controls.Add(this.fullScreen);
            this.settings.Controls.Add(this.windowHeight);
            this.settings.Controls.Add(this.materialLabel3);
            this.settings.Controls.Add(this.windowWidth);
            this.settings.Controls.Add(this.windowResolution);
            this.settings.Controls.Add(this.ramUsageLabel);
            this.settings.Controls.Add(this.ramUsage);
            this.settings.Controls.Add(this.darkTheme);
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(564, 223);
            this.settings.TabIndex = 2;
            this.settings.Text = "Ustawienia";
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(496, 181);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = true;
            this.saveButton.Size = new System.Drawing.Size(68, 36);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ramError
            // 
            this.ramError.AutoSize = true;
            this.ramError.Depth = 0;
            this.ramError.Font = new System.Drawing.Font("Roboto", 11F);
            this.ramError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ramError.Location = new System.Drawing.Point(220, 26);
            this.ramError.MouseState = MaterialSkin.MouseState.HOVER;
            this.ramError.Name = "ramError";
            this.ramError.Size = new System.Drawing.Size(0, 19);
            this.ramError.TabIndex = 24;
            // 
            // fullScreen
            // 
            this.fullScreen.AutoSize = true;
            this.fullScreen.Depth = 0;
            this.fullScreen.Font = new System.Drawing.Font("Roboto", 10F);
            this.fullScreen.Location = new System.Drawing.Point(17, 190);
            this.fullScreen.Margin = new System.Windows.Forms.Padding(0);
            this.fullScreen.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fullScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Ripple = true;
            this.fullScreen.Size = new System.Drawing.Size(102, 30);
            this.fullScreen.TabIndex = 23;
            this.fullScreen.Text = "Pełny ekran";
            this.fullScreen.UseVisualStyleBackColor = true;
            this.fullScreen.CheckedChanged += new System.EventHandler(this.fullScreen_CheckedChanged);
            // 
            // windowHeight
            // 
            this.windowHeight.Depth = 0;
            this.windowHeight.Hint = "";
            this.windowHeight.Location = new System.Drawing.Point(204, 149);
            this.windowHeight.MaxLength = 32767;
            this.windowHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.windowHeight.Name = "windowHeight";
            this.windowHeight.PasswordChar = '\0';
            this.windowHeight.SelectedText = "";
            this.windowHeight.SelectionLength = 0;
            this.windowHeight.SelectionStart = 0;
            this.windowHeight.Size = new System.Drawing.Size(121, 23);
            this.windowHeight.TabIndex = 22;
            this.windowHeight.TabStop = false;
            this.windowHeight.Text = "600";
            this.windowHeight.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(154, 153);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(18, 19);
            this.materialLabel3.TabIndex = 21;
            this.materialLabel3.Text = "X";
            // 
            // windowWidth
            // 
            this.windowWidth.Depth = 0;
            this.windowWidth.Hint = "";
            this.windowWidth.Location = new System.Drawing.Point(17, 149);
            this.windowWidth.MaxLength = 32767;
            this.windowWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.PasswordChar = '\0';
            this.windowWidth.SelectedText = "";
            this.windowWidth.SelectionLength = 0;
            this.windowWidth.SelectionStart = 0;
            this.windowWidth.Size = new System.Drawing.Size(121, 23);
            this.windowWidth.TabIndex = 20;
            this.windowWidth.TabStop = false;
            this.windowWidth.Text = "800";
            this.windowWidth.UseSystemPasswordChar = false;
            // 
            // windowResolution
            // 
            this.windowResolution.AutoSize = true;
            this.windowResolution.Depth = 0;
            this.windowResolution.Font = new System.Drawing.Font("Roboto", 11F);
            this.windowResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowResolution.Location = new System.Drawing.Point(13, 117);
            this.windowResolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.windowResolution.Name = "windowResolution";
            this.windowResolution.Size = new System.Drawing.Size(154, 19);
            this.windowResolution.TabIndex = 19;
            this.windowResolution.Text = "Rozdzielczość ekranu";
            // 
            // ramUsageLabel
            // 
            this.ramUsageLabel.AutoSize = true;
            this.ramUsageLabel.Depth = 0;
            this.ramUsageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ramUsageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ramUsageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ramUsageLabel.Location = new System.Drawing.Point(13, 27);
            this.ramUsageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ramUsageLabel.Name = "ramUsageLabel";
            this.ramUsageLabel.Size = new System.Drawing.Size(185, 19);
            this.ramUsageLabel.TabIndex = 18;
            this.ramUsageLabel.Text = "Maksymalne zużycie ramu";
            // 
            // ramUsage
            // 
            this.ramUsage.Depth = 0;
            this.ramUsage.Hint = "";
            this.ramUsage.Location = new System.Drawing.Point(17, 59);
            this.ramUsage.MaxLength = 32767;
            this.ramUsage.MouseState = MaterialSkin.MouseState.HOVER;
            this.ramUsage.Name = "ramUsage";
            this.ramUsage.PasswordChar = '\0';
            this.ramUsage.SelectedText = "";
            this.ramUsage.SelectionLength = 0;
            this.ramUsage.SelectionStart = 0;
            this.ramUsage.Size = new System.Drawing.Size(547, 23);
            this.ramUsage.TabIndex = 17;
            this.ramUsage.TabStop = false;
            this.ramUsage.Text = "4GB";
            this.ramUsage.UseSystemPasswordChar = false;
            // 
            // darkTheme
            // 
            this.darkTheme.AutoSize = true;
            this.darkTheme.Depth = 0;
            this.darkTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.darkTheme.Location = new System.Drawing.Point(413, 105);
            this.darkTheme.Margin = new System.Windows.Forms.Padding(0);
            this.darkTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkTheme.Name = "darkTheme";
            this.darkTheme.Ripple = true;
            this.darkTheme.Size = new System.Drawing.Size(121, 30);
            this.darkTheme.TabIndex = 16;
            this.darkTheme.Text = "Ciemny motyw";
            this.darkTheme.UseVisualStyleBackColor = true;
            this.darkTheme.CheckedChanged += new System.EventHandler(this.darkTheme_CheckedChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login.Controls.Add(this.onlinePlayers);
            this.login.Controls.Add(this.status);
            this.login.Controls.Add(this.validText);
            this.login.Controls.Add(this.premium);
            this.login.Controls.Add(this.passwordForm);
            this.login.Controls.Add(this.usernameForm);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(564, 223);
            this.login.TabIndex = 0;
            this.login.Text = "Logowanie";
            // 
            // onlinePlayers
            // 
            this.onlinePlayers.AutoSize = true;
            this.onlinePlayers.Depth = 0;
            this.onlinePlayers.Font = new System.Drawing.Font("Roboto", 11F);
            this.onlinePlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.onlinePlayers.Location = new System.Drawing.Point(60, 188);
            this.onlinePlayers.MouseState = MaterialSkin.MouseState.HOVER;
            this.onlinePlayers.Name = "onlinePlayers";
            this.onlinePlayers.Size = new System.Drawing.Size(0, 19);
            this.onlinePlayers.TabIndex = 25;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.White;
            this.status.ForeColor = System.Drawing.SystemColors.ControlText;
            this.status.IconChar = FontAwesome.Sharp.IconChar.None;
            this.status.IconColor = System.Drawing.SystemColors.ControlText;
            this.status.Location = new System.Drawing.Point(532, 214);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(32, 32);
            this.status.TabIndex = 24;
            this.status.TabStop = false;
            // 
            // validText
            // 
            this.validText.AutoSize = true;
            this.validText.Depth = 0;
            this.validText.Font = new System.Drawing.Font("Roboto", 11F);
            this.validText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.validText.Location = new System.Drawing.Point(318, 144);
            this.validText.MouseState = MaterialSkin.MouseState.HOVER;
            this.validText.Name = "validText";
            this.validText.Size = new System.Drawing.Size(0, 19);
            this.validText.TabIndex = 23;
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Checked = true;
            this.premium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.premium.Depth = 0;
            this.premium.Font = new System.Drawing.Font("Roboto", 10F);
            this.premium.Location = new System.Drawing.Point(32, 140);
            this.premium.Margin = new System.Windows.Forms.Padding(0);
            this.premium.MouseLocation = new System.Drawing.Point(-1, -1);
            this.premium.MouseState = MaterialSkin.MouseState.HOVER;
            this.premium.Name = "premium";
            this.premium.Ripple = true;
            this.premium.Size = new System.Drawing.Size(86, 30);
            this.premium.TabIndex = 22;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            this.premium.CheckedChanged += new System.EventHandler(this.premium_CheckedChanged);
            // 
            // passwordForm
            // 
            this.passwordForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordForm.Depth = 0;
            this.passwordForm.Hint = "Hasło";
            this.passwordForm.Location = new System.Drawing.Point(9, 105);
            this.passwordForm.MaxLength = 32767;
            this.passwordForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordForm.Name = "passwordForm";
            this.passwordForm.PasswordChar = '\0';
            this.passwordForm.SelectedText = "";
            this.passwordForm.SelectionLength = 0;
            this.passwordForm.SelectionStart = 0;
            this.passwordForm.Size = new System.Drawing.Size(552, 23);
            this.passwordForm.TabIndex = 4;
            this.passwordForm.TabStop = false;
            this.passwordForm.UseSystemPasswordChar = true;
            // 
            // usernameForm
            // 
            this.usernameForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameForm.Depth = 0;
            this.usernameForm.Hint = "Adres e-mail";
            this.usernameForm.Location = new System.Drawing.Point(9, 46);
            this.usernameForm.MaxLength = 32767;
            this.usernameForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameForm.Name = "usernameForm";
            this.usernameForm.PasswordChar = '\0';
            this.usernameForm.SelectedText = "";
            this.usernameForm.SelectionLength = 0;
            this.usernameForm.SelectionStart = 0;
            this.usernameForm.Size = new System.Drawing.Size(552, 23);
            this.usernameForm.TabIndex = 2;
            this.usernameForm.TabStop = false;
            this.usernameForm.UseSystemPasswordChar = false;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.login);
            this.materialTabControl1.Controls.Add(this.settings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 111);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(572, 249);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabControl1.TabIndex = 18;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(625, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // resolutionError
            // 
            this.resolutionError.AutoSize = true;
            this.resolutionError.Depth = 0;
            this.resolutionError.Font = new System.Drawing.Font("Roboto", 11F);
            this.resolutionError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resolutionError.Location = new System.Drawing.Point(173, 116);
            this.resolutionError.MouseState = MaterialSkin.MouseState.HOVER;
            this.resolutionError.Name = "resolutionError";
            this.resolutionError.Size = new System.Drawing.Size(0, 19);
            this.resolutionError.TabIndex = 26;
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.Depth = 0;
            this.success.Font = new System.Drawing.Font("Roboto", 11F);
            this.success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.success.Location = new System.Drawing.Point(53, 8);
            this.success.MouseState = MaterialSkin.MouseState.HOVER;
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(0, 19);
            this.success.TabIndex = 27;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 412);
            this.Controls.Add(this.close);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.join);
            this.MaximizeBox = false;
            this.Name = "LauncherForm";
            this.Text = "JBWM";
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton join;
        private MaterialFlatButton close;
        private MaterialDivider materialDivider1;
        private TabPage settings;
        private TabPage login;
        private MaterialSingleLineTextField passwordForm;
        private MaterialSingleLineTextField usernameForm;
        private MaterialTabControl materialTabControl1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialCheckBox premium;
        private MaterialCheckBox darkTheme;
        private MaterialLabel ramUsageLabel;
        private MaterialSingleLineTextField ramUsage;
        private MaterialSingleLineTextField windowHeight;
        private MaterialLabel materialLabel3;
        private MaterialSingleLineTextField windowWidth;
        private MaterialLabel windowResolution;
        private MaterialCheckBox fullScreen;
        private MaterialLabel validText;
        private IconPictureBox status;
        private MaterialLabel onlinePlayers;
        private Timer timer1;
        private MaterialLabel ramError;
        private MaterialRaisedButton saveButton;
        private MaterialLabel resolutionError;
        private MaterialLabel success;
    }
}