using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Alperen";
            int age = 21;

            Course course1=new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Alp Alkan";
            course1.ViewerShip = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = "Engin Demirog";
            course2.ViewerShip = 63;

            Course course3 = new Course();
            course3.CourseName = "Phyton";
            course3.Teacher = "Berkay bilgin";
            course3.ViewerShip = 64;

            

            //Console.WriteLine(course1.CourseName + " " + course1.Teacher);

            Course[] courses = new Course[] {course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + " : " + course.Teacher);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public int ViewerShip { get; set; }
    }
}
