using System;
using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;
namespace StudentsApi.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            
        }
        public DbSet <Student> Students { get; set; }

        /*internal void SaveChanges()
        {
            throw new NotImplementedException();
        }*/
    }
}
