using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace tikbotter.service
{
    public class TikTokService
    {

        public async Task<JObject> GetUserDetailsAsync(string username)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tiktok-api6.p.rapidapi.com/user/details?username=" + username),
                Headers =
                {
                    { "X-RapidAPI-Key", "2fdb414371msh1a1b6c39fe8804ep115904jsneb0251168130" },
                    { "X-RapidAPI-Host", "tiktok-api6.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JObject.Parse(body);
            }
        }
    }
}
