using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC3
    {
        public void partTime()
        {
            
            int empRateperHr = 20;
            int fullDayHr = 8;
            int isFullTime = 1;
            int EMpRatePerHr = 20;
            int isPartTime = 2;
            int empHr = 0;
            int empWagesPerDay = 0;
            Random rand = new Random();
            int empCheck = rand.Next(0, 4);
            empWagesPerDay = empHr * EMpRatePerHr;
            switch(empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    break;
                case 1:
                    Console.WriteLine("Present : FullTime Employee");
                    Console.WriteLine("Salary= ", +empHr * EMpRatePerHr);
                    empHr = 8;
                    break;
                case 2:           
                    Console.WriteLine("Present : PartTime EMployee");
                    Console.WriteLine("Salary= ", +empHr * EMpRatePerHr);
                    empHr = 4;
                    break;
                case 3:
                    Console.WriteLine("Holiday");
                    break;
                
                default:
                    Console.WriteLine("Error");
                    break;

            }

        }
    }
}

