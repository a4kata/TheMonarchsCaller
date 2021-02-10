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
            await GetMonarchsCount();
            await GetLongestRuledMonarch();
            await GetLongestRuledHouse();
            await GetMostCommonName();
            //extra
            // await GetMonarchs_List();
        }

        private static void SetupClient()
        {
            client.BaseAddress = new Uri("https://localhost:44357/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/text"));
        }
        private static async Task GetMonarchs_List()
        {
            var response = await client.GetAsync("api/Monarchs/GetMonarchs_All");
            var contetnt = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"GetMonarchs_List -> {contetnt}");
        }
        private static async Task GetMostCommonName()
        {
            var response = await client.GetAsync("api/Monarchs/GetMostCommonName");
            var contetnt = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"GetMostCommonName -> {contetnt}");
        }
        private static async Task GetLongestRuledHouse()
        {
            var response = await client.GetAsync("api/Monarchs/GetLongestRuledHouse");
            var contetnt = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"GetLongestRuledHouse -> {contetnt}");
        }
        private static async Task GetLongestRuledMonarch()
        {
            var response = await client.GetAsync("api/Monarchs/GetLongestRuledMonarch");
            var contetnt = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"GetLongestRuledMonarch -> {contetnt}");
        }
        private static async Task GetMonarchsCount()
        {
            var response = await client.GetAsync("api/Monarchs/GetMonarchsCount");
            var contetnt = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"GetMonarchsCount -> {contetnt}");
        }
    }
}
