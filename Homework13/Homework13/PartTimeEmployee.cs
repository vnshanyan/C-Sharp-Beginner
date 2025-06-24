using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public class PartTimeEmployee: Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public PartTimeEmployee(string name, int hoursWorked, decimal hourlyRate)
        {
            Name = name;
            Contract = ContractType.PartTime;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        public override decimal CalculateMonthlyPay()
        {
            return HoursWorked * HourlyRate;
        }

        public override string GetSummary()
        {
            return $"Name: {Name} | Contract: {Contract} | Salary: {CalculateMonthlyPay():C}";
        }
    }
}
