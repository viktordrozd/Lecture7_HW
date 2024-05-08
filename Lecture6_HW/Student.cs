using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_HW
{
    public class Student : Person
    {
        public List<Course>? Courses { get; set; }

        public Student(string name, int age) //: base(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Courses = new List<Course>();
        }

        public override string DescribeYourself()
        {
            var result = "Student Information: \n\n";

            result += $"Name: {Name} \n";
            result += $"Age: {Age} \n";
            result += $"Courses: {GetCourses()} \n";

            return result;
        }

        private string GetCourses()
        {
            if (Courses.Count == 0)
            {
                return "None";
            }
            else
            {
                var res = "";
                foreach (var course in Courses)
                {
                    res += course.CourseName + " ";
                }
                return res;
            }
        }

        public void AddCourseToStudent(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourseFromStudent(Course course)
        {
            Courses.Remove(course);
        }

        public int GetNumberOfCourses()
        {
            return Courses.Count();
        }
    }
}
