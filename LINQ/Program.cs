using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ - Language Integrated Query
            //LINQ to objects

            int[] numbers = { 12, 2, 45, 65, 78, 89, 69, 78 };

            //Fetch Numbers which are greater than 50
            //Using method syntax
            var numbersGreaterThan50 = numbers.Where(x => x > 50);

            //Using Query Syntax - query expression

            var numbersGreaterThanFifty = from num in numbers
                                          where num > 50
                                          select num;

            string[] names = { "RAayam", "Padas", "James", "Fallen", "Rakesh", "Raju", "Rivalo", "Ronaldinho" };
            //Take out string with length >3 and starts with R
            //Names Having Length>3 and starts with letter R

            /*var result3 = names.Where(x => x.Length > 3 && x.ToLower().StartsWith("R"));
            var result4 = from x in names
                          where x.Length > 3 && x.StartsWith("R")
                          select x;
            foreach (var name in result4)
            {
                Console.WriteLine(name);
            }
*/

            var countries = Country.GetCountries();

            /*var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country;*/

           
           
            // Assg => List Countries in Europe which has population < 100k


            var countriesInEurope = from country in countries
            where country.Continent == "Europe" && country.Population< 100000
            select country;

            foreach(var country in countriesInEurope)
            {
                Console.WriteLine(country.Name);
            }
            // Assg => List Countries in Asia which are never invaded.

        }
    }
}
