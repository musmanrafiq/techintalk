using EfCore5Features.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCore5Features
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var context = new SchoolContext();

            // deleted previous
            var deleted = await context.Database.EnsureDeletedAsync().ConfigureAwait(false);
            // creating an empty one
            var created = await context.Database.EnsureCreatedAsync().ConfigureAwait(false);

            if (deleted && created)
            {
                // seed some data
                var firstStudent = new Student { Name = "Usman" };
                var secondStudent = new Student { Name = "Haider" };

                var firstCourse = new Course { Title = "First", Students = new List<Student> { firstStudent } };
                var secondCourse = new Course { Title = "Second", Students = new List<Student> { secondStudent } };

                //var firstStudentCourse = new StudentCourse { Student = firstStudent, Course = firstCourse };
                //var secondStudentCourse = new StudentCourse { Student = secondStudent, Course = secondCourse };

                context.AddRange(firstCourse, secondCourse);
                _ = await context.SaveChangesAsync();

                var results = await context.Students.Where(x => x.Cources.Any(sc => sc.Title == "Second")).ToListAsync();
                foreach (var result in results)
                {
                    Console.WriteLine($"{result.Name}");
                }
            }

            Console.WriteLine("End of program");
        }
    }
}
