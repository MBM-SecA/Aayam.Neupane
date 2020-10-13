using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Async Programming
            TurnOnBurner();
            PlaceUtilityInBurner("Kettle");
            Pour("Water");
            await Boil("Water");
            GrindTeaMasala();
            PutSugarAndMAsala();
            Pour("Milk");
            await Boil("Milk");
            await Serve("Tea");

            PlaceUtilityInBurner("Pan");
            Pour("Oil");
            Whisk("Eggs");
            await Fry();
            await Serve("Eggs");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");
        }

        void SequentialBreakfast()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Async Programming
            TurnOnBurner();
            PlaceUtilityInBurner("Kettle");
            Pour("Water");
            Boil("Water");
            GrindTeaMasala();
            PutSugarAndMAsala();
            Pour("Milk");
            Boil("Milk");
            Serve("Tea");

            PlaceUtilityInBurner("Pan");
            Pour("Oil");
            Whisk("Eggs");
            Fry();
            Serve("Eggs");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

        }

        void ParallelLearn()
        {

            Console.WriteLine("Hello World!");

            Stopwatch stopwatch = new Stopwatch();
            int[] numbers = { 12, 14, 8, 2, 10, 4, 5, 3 };
            stopwatch.Start();
            //Sequential Programming
            foreach (var num in numbers)
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            }
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            //Parallel Programming 
            Parallel.ForEach(numbers, num =>
            {
                var f = Factorial(num);
                Console.WriteLine($"{num}! = {f}");
            });
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");
        }

        async Task HttpClientCode()
        {
            HttpClient client = new HttpClient();
            Stopwatch stopwatch = new Stopwatch();


            stopwatch.Start();
            var google = client.GetStringAsync("https://google.com/").Result;
            var yahoo = client.GetStringAsync("https://yahoo.com/").Result;
            var facebook = client.GetStringAsync("https://facebook.com/").Result;
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            var googleA = await client.GetStringAsync("https://google.com/");
            var yahooA = await client.GetStringAsync("https://yahoo.com/");
            var facebookA = await client.GetStringAsync("https://facebook.com/");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

        }

        private static Task Serve(string v)
        {
            Console.WriteLine($"Serving {v}");
            Task.Delay(7000);

            return Task.CompletedTask;
        }

        private static Task Fry()
        {
            Console.WriteLine($"Frying Eggs");
            Task.Delay(10000);
            return Task.CompletedTask;

        }

        private static void Whisk(string v)
        {
            Console.WriteLine($"Cracking and whisking {v}");
            Task.Delay(1000);

        }

        private static void Pour(string v)
        {
            Console.WriteLine($"Pouring {v}");

            Task.Delay(5000);

        }

        private static Task Boil(string v)
        {
            Console.WriteLine($"Boiling {v}");
            Task.Delay(2000);
            return Task.CompletedTask;


        }

        private static void GrindTeaMasala()
        {
            Console.WriteLine("Grinding Tea Masala");
            Task.Delay(2000);
        }

        private static void PutSugarAndMAsala()
        {
            Console.WriteLine("Adding Sugar and Tea Masala");

            Task.Delay(2000);
        }


        private static void PlaceUtilityInBurner(string utility)
        {
            Console.WriteLine($"Placing {utility} in the burner");
            Task.Delay(3000);
        }

        private static void TurnOnBurner()
        {
            Console.WriteLine("Turning on burner");
            Task.Delay(2000);
        }

        static long Factorial(long number)
        {
            Task.Delay(2);
            if (number == 1 || number == 0)
                return 1;

            return number * Factorial(number - 1);
        }


    }
}
