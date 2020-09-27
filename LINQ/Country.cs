using System;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public double Area { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }



    public Country(string name, string continent, double area, long population, DateTime Ind = default) //Default = optional parameter
    {
        Name = name;
        Continent = continent;
        Area = area;
        Population = population;
        IndependenceDay = Ind;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country("Nepal", "Asia", 165468.546, 2234861);
        Country c2 = new Country("India", "Asia", 165468.546, 6168468543);
        Country c3 = new Country("Vatican City", "Europe", 165468.546, 98045);
        Country c4 = new Country("Poland", "Europe", 165468.546, 2318746);
        Country c5 = new Country("China", "Asia", 165468.546, 354681351);
        Country c6 = new Country("Denmark", "Europe", 165468.546, 99768);
        Country c7 = new Country("Bangladesh", "Asia", 165468.546, 73131186);
        Country c8 = new Country("Italy", "Europe", 165468.546, 133548766);
        Country c9 = new Country("South Korea", "Asia", 165468.546, 43262197);
        Country c10 = new Country("France", "Europe", 165468.546, 462376951);
        Country c11 = new Country("Indonesia", "Asia", 165468.546, 3214657);
        Country c12 = new Country("Germany", "Europe", 165468.546, 4623751);
        Country c13 = new Country("Sri Lanka", "Asia", 165468.546, 31244675);
        Country c14 = new Country("Spain", "Europe", 165468.546, 53478613);
        Country c15 = new Country("Pakistan", "Asia", 165468.546, 1324678);
        Country c16 = new Country("Portugal", "Europe", 165468.546, 6453785);
        Country c17 = new Country("Iran", "Asia", 165468.546, 65577454);
        Country c18 = new Country("Norway", "Europe", 165468.546, 95000);
        Country c19 = new Country("Iraq", "Asia", 165468.546, 435671512);
        Country c20 = new Country("Belgium", "Europe", 165468.546, 48834321);
        Country c21 = new Country("Israel", "Asia", 165468.546, 47351516);
        Country c22 = new Country("Estonia", "Europe", 165468.546, 75000);
        Country c23 = new Country("UAE", "Asia", 165468.546, 13164758);
        Country c24 = new Country("Greece", "Europe", 165468.546, 352146);
        Country c25 = new Country("Cambodia", "Asia", 165468.546, 1326457);
        Country c26 = new Country("Malta", "Europe", 165468.546, 84036);

        var countries = new List<Country> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25, c26 };
        return countries;
    }

}