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
           
            int PER_HOUR_WAGE = 1000;
            
            int daysWorked = 0;
            int PART_TIME = 1;
            int monthlyWage = 0;
            int noOfDayHoursWorked = 0;
            int dailywage;
            int counterForWhile = 0;
            Random rand = new Random();

            while (noOfDayHoursWorked <= 100 && daysWorked <= 20)
            {
                dailywage = 0;
                int workstatus = rand.Next(0, 3);

                switch (workstatus)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present");
                        break;
                    case 2:
                        Console.WriteLine("Employee has worked part time");
                        dailywage = PER_HOUR_WAGE * PART_TIME;
                        daysWorked++;
                        break;
                    default:
                        Console.WriteLine("something wrong happened");
                        break;
                }
                monthlyWage = monthlyWage + dailywage;
                Console.WriteLine("Total daily wage earned for day " + " " + dailywage);
                Console.WriteLine("No of Hours Worked" + noOfDayHoursWorked);
                monthlyWage += dailywage;
                counterForWhile++;
            }
            Console.WriteLine("Number of times while ran " + counterForWhile);
            Console.WriteLine("Days Worked " + daysWorked);
        }
    }
}