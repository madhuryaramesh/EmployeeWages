using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int isParttime = 1;
        public const int isFulltime = 2;

        //private int numofCompany;
        //private CompanyEmpWage[] computeEmpWageArray;

        private LinkedList<CompanyEmpWage> companyEmpWagesList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        //private string company;
        //private int empRateHrs;
        //private int numWrkDays;
        //private int maxHrMnth;
        //private int totalEmpWage;

        //public const int empRateHrs = 20;
        //public const int numWrkDays = 2;
        //public const int maxHrMnth = 10;
        public EmpWageBuilder()
        {
            this.companyEmpWagesList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
            //this.company = company;
            //this.empRateHrs = empRateHrs;
            //this.numWrkDays = numWrkDays;
            //this.maxHrMnth = maxHrMnth;

        }

        internal string getTotalWage(string v)
        {
            throw new NotImplementedException();
        }

        internal void computeEmpWage()
        {
            throw new NotImplementedException();
        }

        public void addCompanyEmpWage(string company, int empRateHrs, int numWrkDays, int maxHrMnth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRateHrs, numWrkDays, maxHrMnth);
            //numofCompany++;
            this.companyEmpWagesList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);

        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWagesList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
       // private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //    int empHrs = 0;
            //    // int empWage = 0;
            //    int totalEmpWage = 0;
            //    int totalEmpHrs = 0;
            //    int totalWrkDays = 0;
            //    while (totalEmpHrs <= companyEmpWage.maxHrMnth && totalWrkDays < companyEmpWage.numWrkDays)
            //    {
            //        totalWrkDays++;
            //        Random rand = new Random();
            //        int empCheck = rand.Next(0, 3);

            //        switch (empCheck)
            //        {
            //            case isParttime:
            //                empHrs = 4;
            //                break;

            //            case isFulltime:
            //                empHrs = 8;
            //                break;

            //            default:
            //                empHrs = 0;
            //                break;

            //        }
            //        Console.WriteLine("FINAL SOLUTION");
            //        Console.WriteLine("-------------------------------");
            //        totalEmpHrs = totalEmpHrs + empHrs;
            //        Console.WriteLine("Days :" + totalWrkDays + "Employment Hours : " + empHrs);

            //        // Console.WriteLine("Emp Wage is : " + totalEmpWage);


            //    }
            //    return totalEmpHrs*companyEmpWage.empRateHrs;
            //    //totalEmpWage = totalEmpHrs + empRateHrs;
            //    //Console.WriteLine("Total Emp Wagefor company " + company + " is : " + totalEmpWage);


            //}

        }
        // public string toString()
        // {
        //     return "Total Emp Wagefor company " + this.company + " is : " + this.totalEmpWage;
        //}

        public int computeEmpWage(CompanyEmpWage companyEmpWage);
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
