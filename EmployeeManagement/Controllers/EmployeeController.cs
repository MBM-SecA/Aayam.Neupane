using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        //List<Person> employees = new List<Person>();

        //Object initializer syntax
        

        List<Person> employees = Person.GetPerson();
        return View(employees);
    }

    public ActionResult Detail(string FirstName)
    {
        var employee = Person.GetPerson();
        var reqEmployee = from Person in employee where Person.FirstName == FirstName select Person;
        return View(reqEmployee.First());
    }

     public ActionResult Add()
    {
        return View();
    }
 
    [HttpPost]
    public string Add(Person person)
    {
        return "Record saved";
    }
}

