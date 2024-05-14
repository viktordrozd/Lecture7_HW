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

            //The purpose of homework is to finalize the project with students and teachers. Make sure that you have completed all of the listed functions or add them:
            //-displaying all students on the screen(it is obligatory to display all courses for each student)
            //-displaying all teachers(it is obligatory to display all courses for each teacher)
            //-displaying all courses(for each course, display the teacher and all students)

            var philosophy = new Course("1", "Philosophy");
            var alchemy = new Course("2", "Alchemy");

            var student1 = new Student("Student1 Student1", 20);
            var student2 = new Student("Student2 Student2", 21);

            var teacher1 = new Teacher("Phil Philips", 40);
            var teacher2 = new Teacher("Alch Alchy", 555);

            var allStudents = new List<Student>();
            var allTeachers = new List<Teacher>();
            var allCourses = new List<Course>();


            //Adding Students to Teacher
            teacher1.AddStudentToTeacher(student1);
            teacher1.AddStudentToTeacher(student2);

            teacher2.AddStudentToTeacher(student1);
            teacher2.AddStudentToTeacher(student2);

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

            Console.WriteLine("=========================================");

            allCourses.Add(alchemy);
            allCourses.Add(philosophy);

            allStudents.Add(student1);
            allStudents.Add(student2);

            allTeachers.Add(teacher1);
            allTeachers.Add(teacher2);

            //printing all courses
            Console.WriteLine(teacher1.PrintAllCourses(allCourses));

            //printing all students
            Console.WriteLine(teacher1.PrintAllStudents(allStudents));

            //printint all teachers
            Console.WriteLine(PrintAllTeachers(allTeachers));



        }

        public static string PrintAllTeachers(List<Teacher> teachers)
        {
            var allTeachers = "";
            foreach (var teacher in teachers)
            {
                allTeachers += teacher.DescribeYourself() + "\n";
            }
            return allTeachers;
        }

    }
}
