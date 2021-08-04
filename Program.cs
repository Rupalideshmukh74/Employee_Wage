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
            int EMP_RATE_PER_HR = 1000;
            int PART_TIME_HR = 4;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int isPresent = random.Next(0, 2);
            Console.WriteLine(isPresent);
            if (isPresent== IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present full time");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is present part time");
                empHrs = 4;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee wage: " + empWage);
        }
    }
}
