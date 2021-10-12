using System;
using System.Collections.Generic;
using System.Text;

namespace FinalEmpWage
{
    interface IComputeEmpWage
    {
        public void adddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
        public int getTotalWage(string company);
             
    }
}
