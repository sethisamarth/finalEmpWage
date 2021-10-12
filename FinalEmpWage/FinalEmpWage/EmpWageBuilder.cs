using System;
using System.Collections.Generic;
using System.Text;

namespace FinalEmpWage
{
   public class EmpWageBuilder:IComputeEmpWage
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;
         
        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        

        public void adddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);

        }

        public void computeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(computeEmpWage));
                Console.WriteLine(computeEmpWage.tostring());
            }
        }

        public int getTotalWage(string company)
        {
            throw new NotImplementedException();
        }
    }
}
