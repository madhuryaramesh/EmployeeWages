using System;

namespace EmployeeWages
{
   public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wages Computation");
            //EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            //EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 10);
            //dMart.computeEmpWage();
            //Console.WriteLine(dMart.toString());
            //reliance.computeEmpWage();
            //Console.WriteLine(reliance.toString());

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 10);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for DMart Company " +empWageBuilder.getTotalWage("DMart") );
        }
    }
}
