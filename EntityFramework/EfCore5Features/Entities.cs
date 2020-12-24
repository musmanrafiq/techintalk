using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EfCore5Features.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Cources { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Student> Students { get; set; }
    }

    /*public class StudentCourse
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }*/

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost;Database=schooldb;Integrated Security=SSPI");
        }
    }
}
