using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Data;
using StudentsApi.Models;

[Route("students")]
[ApiController]


public class StudentsController : ControllerBase

{
    private StudentContext db;
    public StudentsController(StudentContext _db)
    {
        db = _db;
    }

    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = db.Students.ToList();

        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetAllStudentsById(string Id)
    {
        /*var students = new string[] { "Dipesh", "Swostika" };

        var student = students.Where(x => x == name).FirstOrDefault();*/
        var student = db.Students.Find(Id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(student);
    }
    //hw: Add Student to db
    //configure ef core on thiss API project to use sql server db
    //update each action code to use table
    //Install .NET 5 SDK and try to upgrade all projects 
    [HttpPost]
    [Route("Add")]
    public ActionResult CreateStudent(Student student)
    {

        if (student == null)
        {
            return BadRequest();
        }
        db.Students.Add(student);
        db.SaveChanges();
        return Created("", student);
    }

    [HttpPut]
    [Route("Update")]
    public ActionResult UpdateStudent(Student student)
    {
        if (student == null)
        {
            return BadRequest();
        }
        db.Students.Attach(student);
        db.Students.Update(student);
        db.SaveChanges();
        return Created("Updated", student);
    }
    [HttpDelete]
    [Route("delete")]
    public ActionResult RemoveStudent(Student student)
    {
        if (student == null)
        {
            return BadRequest();
        }
        db.Students.Attach(student);
        db.Students.Remove(student);
        db.SaveChanges();
        var result = $"Removed {student.Name} with id={student.Id}";
        return Ok(result);
    }
}