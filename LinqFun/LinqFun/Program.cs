using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqFun.Data;
using LinqFun.Models;

namespace LinqFun
{
    class Program
    {
        static void Main(string[] args)
        {
            AnonymousTypes();
            Joins();
            Console.ReadLine();

        }

        static void AnonymousTypes()
        {
            Console.WriteLine("****AnonymousTypes****");
            //getting our data from our repository
            //going to see this a lot!!
            List<Student> students = StudentRepo.GetAllStudents();

            //query syntax...ONLY USE VAR HERE!!!!
            var ladies = from chicks in students
                where chicks.Gender == "F"
                select new
                {
                    Name = $"{chicks.FirstName} {chicks.LastName}",
                    chicks.Major
                };

            //ONLY USE VAR HERE ALSO..Every TIME!!!!
            foreach (var lady in ladies)
            {
                Console.WriteLine($"{lady.Name} is Majoring in {lady.Major}");

            }
            Console.WriteLine();
        }

        static void Joins()
        {
            Console.WriteLine("****Joins*****");
            List<Student> students = StudentRepo.GetAllStudents();
            List<Course> courses = StudentRepo.GetAllStudentCourses();

            //join the student to the course the student is taking




            //Query syntax

            var results = from s in students
                join c in courses
                    on s.ID equals c.StudentId
                select new
                {
                    c.CourseName,
                    StudentName = $"{s.FirstName} {s.LastName}"
                };

            foreach (var result in results)
            {
                Console.WriteLine($"{result.StudentName} {result.CourseName}");
            }

            Console.ReadLine();


        }
    }
}
