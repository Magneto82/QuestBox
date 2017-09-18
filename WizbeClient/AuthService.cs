using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WizbeClient
{
    public class AuthService
    {
        private readonly string _baseUri;
        public AuthService(string baseUri)
        {
            _baseUri = baseUri;
        }
        public Dictionary<string, string> Login(string userName, string password)
        {
            var pairs = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>( "grant_type", "password" ),
                new KeyValuePair<string, string>( "username", userName ),
                new KeyValuePair<string, string> ( "Password", password )
            };
            var content = new FormUrlEncodedContent(pairs);

            using (var client = new HttpClient())
            {
                var response =
                    client.PostAsync(_baseUri + "/token", content).Result;
                var result = response.Content.ReadAsStringAsync().Result;

                // Десериализация полученного JSON-объекта
                Dictionary<string, string> tokenDictionary =
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
                return tokenDictionary;
            }
        }
        public static HttpClient CreateClient(string accessToken = "")
        {
            var client = new HttpClient();
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            return client;
        }
    }
}
