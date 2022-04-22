using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC4
    {
        public static void Monthly_Sal()
        {
            /*Variable Declarations*/
            int empWageperHr = 20;
            int fullTimeHr = 8;
            int partTimeHr = 4;
            int WorkingDays = 20;            
            int empWagesPerDay;
            Random rand = new Random();
            int empCheck = rand.Next(0, 4);

            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    empWagesPerDay = fullTimeHr * empWageperHr;
                    Console.WriteLine("Present : FullTime Employee");
                    Console.WriteLine("Per day Salary : " + empWagesPerDay);
                    Console.WriteLine("Monthly Salary : " + empWagesPerDay * WorkingDays);
                    break;
                case 2:
                    empWagesPerDay = partTimeHr * empWageperHr;
                    Console.WriteLine("Present : PartTime EMployee");
                    Console.WriteLine("Salary : " + empWagesPerDay);
                    Console.WriteLine("Monthly Salary : " + empWagesPerDay * WorkingDays);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
