using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeWageComputation
{
    interface IEmpWageBuilderArray
    {
        public void AddCompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays);
        public void ComputeEmpWage();
        public int ComputeEmpWage(EmployeeClass employeeClass);
    }
}
