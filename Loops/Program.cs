using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Software Developer Training Camp";
            string course2 = "Basic Course for Beginner Programming";
            string course3 = "Java";
            string course4 = "Python";
            string course5 = "C++";

            //array

            string[] courses = new string[] { "Software Developer Training Camp", "Basic Course for Beginner Programming","Java","Pyhton","C++" };


            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For finished");

            foreach (string course  in courses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Page Break - footer");
        }
    }
}
