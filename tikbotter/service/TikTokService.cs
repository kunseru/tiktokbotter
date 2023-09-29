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
                    { "X-RapidAPI-Key", "putyourkeyhere" },
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
