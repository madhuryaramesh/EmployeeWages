using System;

namespace EmployeeWages
{
    class Program
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;

        public static int UCEwage(string company, int empRateHrs, int numWrkDays, int maxHrMnth)
        {
            int empHrs = 0;
            // int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWrkDays = 0;
            while (totalEmpHrs <= maxHrMnth && totalWrkDays < numWrkDays)
            {
                totalWrkDays++;
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
                Console.WriteLine("UC8");
                Console.WriteLine("-------------------------------");
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Days :" + totalWrkDays + "Employment Hours : " + empHrs);

                // Console.WriteLine("Emp Wage is : " + totalEmpWage);

            }
            totalEmpWage = totalEmpHrs + empRateHrs;
            Console.WriteLine("Total Emp Wagefor company " + company + " is : " + totalEmpWage);
            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wages Computation");
            //UCEmp uCEmp = new UCEmp();
            UCEwage("DMART",20,2,10);
            UCEwage("RELIANCW", 10, 4, 20);

        }
    }
}
