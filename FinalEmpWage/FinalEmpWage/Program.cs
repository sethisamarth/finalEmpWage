using System;

namespace FinalEmpWage
{
   public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numofWorkingDays;
        public int maxHoursPerMounth;
        public int totalEmpWage;
        private int maxHoursPerMonth;

       

        public CompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth) 
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = 0;

        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp wage for company:"+ this.company + "is:" + this.totalEmpWage;
        }
    }
    
    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
