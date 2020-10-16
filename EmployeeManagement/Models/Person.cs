using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    [Display(Name = "First Name")]
    [Required (ErrorMessage = "First Name required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last Name required")]
    public string Surname { get; set; }

    public string Address { get; set; }
    
    public double Salary { get; set; }
    
    public char Gender { get; set; } = 'M';

    public static List<Person> GetPerson()
    {
        Person emp1 = new Person()
        {
            FirstName = "Aayam",
            Surname = "Neupane",
            Address = "Jagati",
            Salary = 100000.0
        };
        Person emp2 = new Person()
        {
            FirstName = "Atanka",
            Surname = "Neupane",
            Address = "Jagati",
            Salary = 100000.0
        };
        Person emp3 = new Person()
        {
            FirstName = "Sandhya",
            Surname = "Neupane",
            Address = "Jagati",
            Salary = 100000.0
        };
        Person emp4 = new Person()
        {
            FirstName = "Anjali",
            Surname = "Neupane",
            Address = "Jagati",
            Salary = 100000.0
        };

        List<Person> employees = new List<Person> { emp1, emp2, emp3, emp4 };
        return employees;
    }
}