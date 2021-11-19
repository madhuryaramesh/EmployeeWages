﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class UCEmp
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;
        public const int empRateHrs = 20;
        public const int numWrkDays = 2;
        public void UCEwage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < numWrkDays; day++)
            {
                Random rand = new Random();
                int empCheck = rand.Next(0, 3);
                //if (empCheck == isParttime)
                //{
                //    empHrs = 4;
                //}
                //else if (empCheck == isFulltime)
                //{
                //    empHrs = 8;
                //}
                //else
                //{
                //    empHrs = 0;
                //}
                switch (empCheck)
                {
                    case isParttime:
                        empHrs = 4;
                        break;

                    case isFulltime:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;

                }
                Console.WriteLine("UC5");
                Console.WriteLine("-------------------------------");
                empWage = empHrs * empRateHrs;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Emp Wage is : " + empWage);

            }

            Console.WriteLine("Total Emp Wage is : " + totalEmpWage);
            Console.WriteLine("-------------------------------");
        }
    }
}
