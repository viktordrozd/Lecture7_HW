using System.Buffers.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Lecture6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-add a collection of students to the teacher
            //- add a collection of students to the course
            //- add a collection of courses to a student
            //- add a collection of courses to the teacher
            //- implement collection management methods(add, remove, get the number of elements in the collection)

            var philosophy = new Course("1", "Philosophy");
            var alchemy = new Course("2", "Alchemy");

            var student1 = new Student("Student1 Student1", 20);
            var student2 = new Student("Student2 Student2", 21);

            var teacher1 = new Teacher("Phil Philips", 40);
            var teacher2 = new Teacher("Alch Alchy", 555);


            //Adding Students to Teacher
            teacher1.AddStudentToTeacher(student1);
            teacher1.AddStudentToTeacher(student2);

            //Printing Teacher
            Console.WriteLine(teacher1.DescribeYourself());

            //Adding Courses to Teacher
            teacher1.AddCourseToTeacher(alchemy);
            teacher1.AddCourseToTeacher(philosophy);

            //Printing Teacher
            Console.WriteLine(teacher1.DescribeYourself());

            //Getting Students count
            Console.WriteLine(teacher1.GetStudentsCount());
            
            //Getting Courses count
            Console.WriteLine(teacher1.GetCoursesCount()); 

            //Removing Courses and Students from Teacher
            teacher1.RemoveCourseFromTeacher(alchemy);
            teacher1.RemoveStudentFromTeacher(student2);
            teacher1.RemoveStudentFromTeacher("Student1");

            //Printing Teacher
            Console.WriteLine(teacher1.DescribeYourself());

            //Adding courses to Student
            student1.AddCourseToStudent(alchemy);
            student1.AddCourseToStudent(philosophy);

            //Printing Student
            Console.WriteLine(student1.DescribeYourself());

            //Adding Students to Course
            alchemy.AddStudentToCourse(student1);
            alchemy.AddStudentToCourse(student2);


            //printing students
            Console.WriteLine(student1.DescribeYourself());
            Console.WriteLine(student2.DescribeYourself());

            //adding teacher to Course
            alchemy.Teacher = teacher1;
            philosophy.Teacher = teacher2;

            //printing courses
            Console.WriteLine(alchemy.PrintCourse());
            Console.WriteLine(philosophy.PrintCourse());


        }
    }
}
