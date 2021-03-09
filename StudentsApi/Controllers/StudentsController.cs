using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentsApi.Models;

[Route("students")]
[ApiController]


public class StudentsController : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] { "Dipesh", "Swostika" };
        students = null;
        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetAllStudentsById(string name)
    {
        var students = new string[] { "Dipesh", "Swostika" };

        var student = students.Where(x => x == name).FirstOrDefault();

        if (students == null)
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
        return Created("", student);
    }

    [HttpDelete]
    [Route("Delete")]
    public ActionResult DeleteStudent(Student student)
    {

        if (student == null)
        {
            return BadRequest();
        }
        return Created("", student);
    }
}
