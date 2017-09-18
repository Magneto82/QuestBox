using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WizbeClient.DTO;

namespace WizbeClient
{
    public class GameService
    {
        public static IList<TeamViewSmallModel> GetTeamsForGame(string uri, string token, string gameId)
        {
            using (var client = AuthService.CreateClient(token))
            {
                var response = client.GetAsync($"{uri}/api/Game/SelectTeam/{gameId}").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                // Десериализация полученного JSON-объекта
                TeamsAnswer answer = JsonConvert.DeserializeObject<TeamsAnswer>(result);
                if (!answer.Success)
                    throw new Exception(answer.StringErrors());
                return answer.Data;
            }
        }
        //return baseService.put($rootScope.serviceBase + '/Game/Join/' + id + '/' + teamId, null, headers);
        public static JoinGameViewModel JoinGameWithTeam(string uri, string token, string gameId, string teamId)
        {
            using (var client = AuthService.CreateClient(token))
            {
                var response = client.PutAsync($"{uri}/api/Game/Join/{gameId}/{teamId}", null).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                JoinGameAnswer answer = JsonConvert.DeserializeObject<JoinGameAnswer>(result);
                if (!answer.Success)
                    throw new Exception(answer.StringErrors());
                return answer.Data;
            }
        }

        public static IList<ShortUser> GetTestUserList(string uri)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(uri + "/api/users/testusers").Result;
                var result = response.Content.ReadAsStringAsync().Result;

                TestUserListAnswer answer = JsonConvert.DeserializeObject<TestUserListAnswer>(result);
                if (!answer.Success)
                    throw new Exception(answer.StringErrors());
                return answer.Data;
            }
        }
    }
}
