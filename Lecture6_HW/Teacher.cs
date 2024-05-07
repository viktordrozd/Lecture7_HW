using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_HW
{
    public class Teacher : Person
    {

        public List<Student> Students;
        public List<Course> Courses;

        public Teacher(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        public override string DescribeYourself()
        {
            var result = "Teacher Information: \n\n";

            result += $"Name: {Name} \n";
            result += $"Age: {Age} \n";
            result += $"Students: {GetStudents()} \n";
            result += $"Courses: {GetCourses()} \n";

            return result;
        }

        private string GetStudents()
        {
            if (Students.Count == 0)
            {
                return "None";
            }
            else
            {
                var res = "";
                foreach (var student in Students)
                {
                    res += student.Name + " ";
                }
                return res;
            }
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

        public void AddStudentToTeacher(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudentFromTeacher(Student student)
        {
            Students.Remove(student);
        }

        public void RemoveStudentFromTeacher(string name)
        {
            if (name.Length >= 3)
            {
                Students.RemoveAll(x => x.Name.Contains(name));
            }
            else
            {
                Console.WriteLine("No such students found");
            }
        }

        public int GetStudentsCount()
        {
            return Students.Count();
        }

        public void AddCourseToTeacher(Course course)
        {
            Courses.Add(course);
        }

        public void RemoveCourseFromTeacher(Course course)
        {
            Courses.Remove(course);
        }

        public int GetCoursesCount()
        {
            return Courses.Count();
        }
    }
}
