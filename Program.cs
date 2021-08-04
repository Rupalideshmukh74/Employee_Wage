using System;

namespace EmployeePayRole
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to employee wage problem ");
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int isPresent = random.Next(0, 2);
            Console.WriteLine(isPresent);
           // if (isPresent== IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
