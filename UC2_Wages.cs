using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC2
    {
        public void salary()
        {


            int isFullTime = 1;
            int EMpRatePerHr = 20;
            int isPartTime = 2;
            int empHr = 0;
            int empWages = 0;
            Random rand = new Random();
            int empCheck = rand.Next(0, 4);
            if (empCheck == isFullTime)
            {
                empHr = 8;
            }
            else
                empHr = 4;
            empWages = empHr * EMpRatePerHr;
            Console.WriteLine("Salary= ", +empWages);


        }
    }
}
