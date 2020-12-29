using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EfCore5Features.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Cources { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
    }

    public class StudentCourse
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime JoinedDate { get; set; } = DateTime.Now;
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost;Database=schooldb;Integrated Security=SSPI");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Cources)
                .WithMany(y => y.Students)
                .UsingEntity<StudentCourse>(
                j => j.HasOne(x => x.Course).WithMany(y => y.StudentCourses),
                j => j.HasOne(x => x.Student).WithMany(y => y.StudentCourses)
                );
        }
    }
}
