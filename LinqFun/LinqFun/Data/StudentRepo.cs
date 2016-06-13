using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using LinqFun.Models;

namespace LinqFun.Data
{
    public class StudentRepo
    {
        public static List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    ID = 1,
                    FirstName = "Bart",
                    LastName = "Simpson",
                    Gender = "M",
                    Major = "Political Science",
                },

                new Student()
                {
                    ID = 2,
                    FirstName = "Lisa",
                    LastName = "Simpson",
                    Gender = "F",
                    Major = "Arts",
                },

                new Student()
                {
                    ID = 3,
                    FirstName = "Bugs",
                    LastName = "Bunny",
                    Gender = "M",
                    Major = "Theater",
                },
                new Student()
                {
                    ID = 4,
                    FirstName = "Lola",
                    LastName = "Bunny",
                    Gender = "F",
                    Major = "Finance",
                },
                

            };
        }

        public static List<Course> GetAllStudentCourses()
        {
            return new List<Course>()
            {
                new Course() {StudentId = 2, CourseName = "Government"},
                new Course() {StudentId = 2, CourseName = "Math"},
                new Course() {StudentId = 1, CourseName = "Math"},
                new Course() {StudentId = 3, CourseName = "Math"},
                new Course() {StudentId = 4, CourseName = "Intro to Programming"},

            };

        }
    }
}
