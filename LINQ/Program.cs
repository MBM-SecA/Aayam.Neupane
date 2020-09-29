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
            }*/

            //Projection
            var result5 = numbers.Select(x => x * x);
            foreach (var square in result5)
            {
                Console.WriteLine(square);
            }

            //Ordering
            var result7 = from name in names
                          orderby name descending
                          select name;
            foreach (var name in result7)
            {
                Console.WriteLine(name);
            }

            var result6 = from num in numbers
                          orderby num
                          select num;
            foreach (var square in result6)
            {
                Console.WriteLine(square);
            }


            //Data partitioning
            var result9 = numbers.Skip(5).Take(5);
            foreach (var num in result9)
            {
                Console.WriteLine(num);
            }


            //Quantifier
            var result10 = numbers.Any(x => x % 2 == 0);
            var result11 = numbers.All(x => x % 2 == 0);
            var result12 = numbers.Contains(34);
            Console.WriteLine(result10);


            //Enumerable class
            var result13 = Enumerable.Range(1,1000);
            foreach (var num in result13)
            {
                Console.WriteLine(num);
            }
            var result14 = Enumerable.Repeat("Hello World", 10);
            Console.WriteLine(result14);



            //HW - Is there any african country in your collection



            ComplexType complexType = new ComplexType();
            complexType.Restrictions();
            //HW - Print first 2 largest asia countries names  
    

            

        }
    }
}
