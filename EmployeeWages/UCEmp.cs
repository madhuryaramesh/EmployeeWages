using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class UCEmp
    {
        //public const int isParttime = 1;
        public const int isFulltime = 1;
        //public const int empRateHrs = 20;
        public void UCEwage()
        {
           // int empHrs = 0;
            //int empWage = 0;
            Console.WriteLine("UC1");
            Console.WriteLine("-------------------------------");
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == isFulltime)
            {
                Console.WriteLine("Employee is Present");
            }

            else
            {
                Console.WriteLine("Employee is Present");
            }

            Console.WriteLine("-------------------------------");

        }
    }
}
