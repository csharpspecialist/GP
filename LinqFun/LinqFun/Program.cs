using System;
using System.Collections.Generic;
using System.Data.Common;
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
            GroupBy();
            AnonymousTypesMethod();
            GroupByAgain();
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

            // Console.Writeline();


        }

        static void GroupBy()
        {
            Console.WriteLine("****Groupby*****");

            var students = StudentRepo.GetAllStudents();
            //query syntax
            var results = (from s in students
                orderby s.FirstName
                group s by s.Major).Take(1);


            foreach (var group in results)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName}{student.LastName} - {student.Major}");
                }
                //
                Console.ReadLine();
            }


        }


        static void AnonymousTypesMethod()
        {
            Console.WriteLine("****AnonymousTypes Using Methods****");
            //getting our data from our repository
            //going to see this a lot!!
            List<Student> students = StudentRepo.GetAllStudents();

            //METHOD syntax...ONLY USE VAR HERE!!!!
            var girls = students.Where(s => s.Gender == "F").Select(x => new

            {
                Name = $"{x.FirstName} {x.LastName}",
                x.Major
            });

            //ONLY USE VAR HERE ALSO..Every TIME!!!!
            //foreach (var lady in ladies)
            //{
            //    Console.WriteLine($"{lady.Name} is Majoring in {lady.Major}");

            //}
            Console.WriteLine();
        }

        static void JoinsAgain()
        {
            Console.WriteLine("****Joins*****");
            List<Student> students = StudentRepo.GetAllStudents();
            List<Course> courses = StudentRepo.GetAllStudentCourses();

            //join the student to the course the student is taking
            //Query syntax

            var results = students.Join(courses, student => student.ID, course => course.StudentId
                , (student, course) => new
                {
                    course.CourseName,
                    StudentName = $"{student.FirstName} {student.LastName}"
                });

            foreach (var result in results)
            {
                Console.WriteLine($"{result.StudentName} {result.CourseName}");
            }



        }

        static void GroupByAgain()
        {
            Console.WriteLine("****Groupby...Again!!!*****");

            var students = StudentRepo.GetAllStudents();
            //query syntax
            var results = students.Where(student => student.Major != "Chemistry")
                .OrderByDescending(s => s.Major)
                .ThenBy(s => s.LastName)
                .GroupBy(student => student.Major);




            foreach (var group in results)
            {
                Console.WriteLine(group.Key);

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName}{student.LastName} - {student.Major}");
                }
                //
                Console.ReadLine();
            }


        }
    }
}
