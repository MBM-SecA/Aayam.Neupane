using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main()
        {
            // Making Breakfast

            //Make Coffee
            //Light the burner (2s)
            //Put kettle on the burner(2s)
            //Pour Water (5s)
            //Boil the water (5 min)
            //Grind Masalas (1 min)
            //Put Sugar and masalas(5s)
            //Pour Milk (5s)
            //Boil Milk (3 min)
            //Turn on another buber(2s)
            //Place the pan on the burner and oil it(30s)
            //Crack eggs and whisk it(3min)
            //Fry it (3m)

            
            HttpClient client = new HttpClient();
            Stopwatch stopwatch = Stopwatch.StartNew();
            var google = client.GetStringAsync("https://www.google.com").Result;
            var microsoft = client.GetStringAsync("https://www.microsoft.com/en-us/").Result;
            var yahoo = client.GetStringAsync("https://search.yahoo.com/web").Result;
            Console.WriteLine($"It took{stopwatch.ElapsedMilliseconds} ms");

           
           stopwatch.Restart();
           var G = client.GetStringAsync("https://www.google.com");
            var M = client.GetStringAsync("https://www.microsoft.com/en-us/");
            var Y = client.GetStringAsync("https://search.yahoo.com/web");
            Console.WriteLine($"It took{stopwatch.ElapsedMilliseconds} ms");






        }
    }
}
