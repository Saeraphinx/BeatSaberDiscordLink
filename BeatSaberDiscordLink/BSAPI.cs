using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace BeatSaberDiscordLink
{
    class BSAPI
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main()
        {
            await PullFullMap("76561198323656813");

            Console.ReadKey();
        }

        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.


        public static async Task<dynamic> PullFullMap(string ID)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try {
                HttpResponseMessage response = await client.GetAsync("https://api.beatsaver.com/maps/id/" + ID);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
                dynamic ScoreSaberProfile = JsonConvert.DeserializeObject(responseBody);
                return ScoreSaberProfile;
            } catch {
                return JsonConvert.DeserializeObject("{\"error\": \"Not Found\"}");
            }
        }
    }
}
