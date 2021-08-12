﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageComputation
{
    public interface IComputeEmpWage
    {


        public void AddCompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays);
        public void ComputeEmpWage();
        public void SetTotalEmpWage(int TotalEmpWage);

    }
    public class EmployeeClass
    {
        public string Company;
        public int WagePerHour;
        public int MaxHoursPerMonth;
        public int MaxWorkingDays;
        public int TotalEmpWage;


        public EmployeeClass(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            this.Company = company;
            this.WagePerHour = wagePerHour;
            this.MaxHoursPerMonth = maxHoursPerMonth;
            this.MaxWorkingDays = maxWorkingDays;
        }
        public void SetTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }

        public string ToString()
        {
            return "Total employee wage for " + this.Company + " is " + this.TotalEmpWage;




        }

    }
}



