using System;

namespace EmployeWageComputation
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Welcome to Employee Wage Problem--------------------");

            //EmployeeClass BMW = new EmployeeClass("Bmw",20,9,100);
            //EmployeeClass TATA = new EmployeeClass("TATA", 21, 15, 900);
            //TATA.CompanyEmpWage();

            //BMW.CompanyEmpWage();
            //EmpWageBuilderArray emp
            EmpWageBuilderArray emp1 = new EmpWageBuilderArray();
            emp1.AddCompanyEmpWage("bmw", 20, 2, 100);
            emp1.AddCompanyEmpWage("tata", 30, 4, 200);
            emp1.ComputeEmpWage();

        }
    }
}

 





