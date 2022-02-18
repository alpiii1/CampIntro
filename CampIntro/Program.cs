using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            
            string categoryTag = "category";
            int numberofStudents = 32000;
            double interestRate = 1.45;
            bool haveYouLoggedIntotheSystem = true;
            double yesterdayValueofDollar = 9.50;
            double presentValueofDollar = 9.60;
            
            if (yesterdayValueofDollar > presentValueofDollar)
            {
                Console.WriteLine("Decrease bar");
            }
            else if (yesterdayValueofDollar < presentValueofDollar)
            {
                Console.WriteLine("Increase bar");
            }
            else
            {
                Console.WriteLine("Unchanged button");
            } 

            
            if (haveYouLoggedIntotheSystem == false) 
            {
                Console.WriteLine("User settings button");
            }
            else
            {
                Console.WriteLine("Login button");
            }


            Console.WriteLine(categoryTag);
            

        }
    }
}
