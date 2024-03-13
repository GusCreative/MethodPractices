
using System;
using System.ComponentModel.DataAnnotations;

namespace MethodPractice
{

    class Car
    {

        void make()
        {
            Console.WriteLine("Toyota");
        }
        void make1()
        {
            Console.WriteLine("Honda");
        }

        void model()
        {
            Console.WriteLine("Odyssey");
            ;
        }
        void year()
        {
            Console.WriteLine("2015");


        }
        void displayInfo()
        {
            Console.Write("Make: "); make();
            Console.Write("Make: "); make1();
            Console.Write("model: "); model();
            Console.Write("year: "); year();
        }


        static void Main(string[] args)
        {
            Car display = new Car();
            display.displayInfo();

        }
    }


    class User
    {
        void name()
        {
            Console.WriteLine("Gustavo Adrian");
        }
        void age()
        {
            Console.WriteLine("39");
        }
        void salary()
        {
            Console.WriteLine("$160.000");
        }
        void userDetails()
        {
            Console.WriteLine("Name: "); name();
            Console.WriteLine("Age: "); age();
            Console.WriteLine("Salary: "); salary();
        }


        static void Main(string[] args)
        {
            try { 
            User userInformation = new User();
            userInformation.userDetails();

            Console.WriteLine("Are you above 18 years? Please write 'Y' or 'N'");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'Y')
            {
                userInformation.userDetails();
            }
            else
            {
                Console.WriteLine("Sorry, you are under age!");
            }

            Console.WriteLine("Are you willing to share salary information?, Please write 'Y' or 'N'");
            char input2 = Convert.ToChar(Console.ReadLine());
            if (input2 == 'Y')
            {
                userInformation.salary();
            }
            else
            {
                Console.WriteLine("No problem, Thank you!");
            }
            } catch(Exception e)
            {
                Console.WriteLine("The exception has been handle: " +  e.Message);
            }

        }
       

    }
}



