using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{

    private readonly EMSContext db;

    public EmployeeController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        //List<Person> employees = new List<Person>();

        //Object initializer syntax
        var employees = db.People.ToList();
        //List<Person> employees = Person.GetPerson();
        return View(employees);
    }

    public ActionResult Detail(int Id)
    {
        var employee = db.People.Find(Id);
        return View(employee);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add([FromForm] Person person)
    {
        db.People.Add(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public ActionResult Edit(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult<string> Edit([FromForm] Person person)
    {
        db.People.Attach(person);
        db.People.Update(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }
    [HttpPost]
    public ActionResult Delete(Person person)
    {
        db.People.Attach(person);
        db.People.Remove(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}


