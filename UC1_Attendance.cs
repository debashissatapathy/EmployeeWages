using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    public class UC1
    {
        public void Attendance()
        {
            int empHr = 0;
            Random random = new Random();
            int emp_check = random.Next(2);
            if (emp_check == 1)
            {
                Console.WriteLine("Employee is present and type FullTIme");
                empHr = 8;
            }
            else if(emp_check == 2)
            {
                Console.WriteLine("Employee is present and type PartTIme");
                empHr = 4;
            }
            else
                Console.WriteLine("Employee is Absent");
                empHr = 0;
        }
    }

}
