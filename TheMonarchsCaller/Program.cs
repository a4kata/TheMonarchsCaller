using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TheMonarchsCaller
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            SetupClient();
            await CallMonarchAPI("GetMonarchsCount");
            await CallMonarchAPI("GetLongestRuledMonarch");
            await CallMonarchAPI("GetLongestRuledHouse");
            await CallMonarchAPI("GetMostCommonName");
            //extra
            //await CallMonarchAPI("GetMonarchs_All");
        }

        private static void SetupClient()
        {
            client.BaseAddress = new Uri("https://localhost:44357/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/text"));
        }
        private static async Task CallMonarchAPI(string method)
        {
            var response = await client.GetAsync($"api/Monarchs/{method}");
            var contetnt = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"{method} -> {contetnt}");
        }
    }
}
