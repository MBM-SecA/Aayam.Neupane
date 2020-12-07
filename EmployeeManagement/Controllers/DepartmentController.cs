using System.Linq;
using Microsoft.AspNetCore.Mvc;

public class DepartmentController: Controller
{
    private readonly EMSContext db;

    public DepartmentController(EMSContext _db)
   {
        db = _db;
    }
     
    public ActionResult Index()
    {
        
        var Departments = db.Departments.ToList();
        return View(Departments);
    }
    public ActionResult Detail([FromQuery]int id)
    {  
       var  Department = db.Departments.Find(id);
       return View(Department);
        
    }

[HttpGet]
    public ActionResult Add()
    {
        return View();
    }
[HttpPost]
    public ActionResult Add([FromForm]Department Department)
    {
        db.Departments.Add(Department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public ActionResult Edit([FromQuery]int id)
    {  
       var  Department = db.Departments.Find(id);
       return View(Department);
        
    }
    [HttpPost]
public ActionResult Edit([FromForm]Department department)
    {  
       db.Departments.Attach(department);
       db.Departments.Update(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    
        
    }
[HttpGet]
 public ActionResult Delete([FromQuery]int id)
    {  
       var  department = db.Departments.Find(id);
       return View(department);
        
    }
    [HttpPost]
public ActionResult Delete([FromForm]Department department)
    {  
       db.Departments.Attach(department);
       db.Departments.Remove(department);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));

    
        
    }

}