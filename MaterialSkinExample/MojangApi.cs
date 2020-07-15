using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JBWMLauncher {
    public class MojangApi {
        private static readonly HttpClient client = new HttpClient();
        private static string authUrl = "https://authserver.mojang.com/authenticate";

        public async Task<bool> getAccesToken(string username, string password) {
            var values = new Dictionary<string, dynamic>{
                    { "agent", new Dictionary<string, string>{
                            { "name", "minecraft" },
                            { "version", "1" },
                        }
                    },
                    { "username", username },
                    { "password", password }
                };

            string authJson = JsonConvert.SerializeObject(values);

            var content = new StringContent(authJson.ToString(), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync(authUrl, content);

            var text = await response.Result.Content.ReadAsStringAsync();

            if(response.Result.StatusCode == System.Net.HttpStatusCode.OK) {
                Debug.WriteLine("ZALOGOWANY");

                return true;
            }

            return false;
        }
    }
}
