using System;
using System.Collections.Generic;
using System.Linq;
public class ComplexType
{
    public void Restrictions()
    {
        var countries = Country.GetCountries();

        var asianCountries = from country in countries
                             where country.Continent == "Asia"
                             select country;



        // Assg => List Countries in Europe which has population < 100k


        var countriesInEurope = from country in countries
                                where country.Continent == "Europe" && country.Population < 100000
                                select country;

        foreach (var country in countriesInEurope)
        {
            Console.WriteLine(country.Name);
        }



        //HW - Is there any african country in your collection
        var countriesInAfrica = countries.Any(x => x.Continent == "Africa");
        if (countriesInAfrica)
        {
            Console.WriteLine("Yes there are african countries in your data collection");
            var africa = countries.Where(x => x.Continent == "Africa");

            foreach (var country in africa)
            {
                Console.WriteLine($"They are Listed as {country.Name}");
            }
        }
        else
        {
            Console.WriteLine("There are not any countries in your data collection");
        }


        //HW - Print first 2 largest asia countries names

        var largestAsianCountries = countries.OrderByDescending(c => c.Area);

        var firstTwo = largestAsianCountries.Take(2);
        foreach (var country in firstTwo)
        {
            Console.WriteLine($"The two largest area countries are:{country.Name}");
        }

        // Assg => List Countries in Asia which are never invaded.

        var freeAsian = from country in countries
                        where country.Continent == "Asia" && country.IndependenceDay == default
                        select country;
        Console.WriteLine("Asian Countries which were never invaded");
        foreach (var x in freeAsian)
        {
            Console.WriteLine(x.Name);
        }



    }







}
