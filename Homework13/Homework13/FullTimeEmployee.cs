using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public class FullTimeEmployee: Employee, IPerformanceEvaluated
    {
        public decimal BaseSalary { get; set; }
        public decimal PerformanceBonus { get; set; }
        public int PerformanceScore { get; set; }
        
        public FullTimeEmployee(string name, decimal baseSalary, decimal performanceBonus, int performanceScore)
        {
            BaseSalary = baseSalary;
            PerformanceBonus = performanceBonus;
            PerformanceScore = performanceScore;
            Name = name;
            Contract = ContractType.FullTime;
        }

        public override decimal CalculateMonthlyPay()
        {
            return PerformanceScore > 80 ? PerformanceBonus + BaseSalary : BaseSalary;
        }

        public override string GetSummary()
        {
            string bonusApplied = PerformanceScore > 80 ? $"Yes (Score: {PerformanceScore})" : $"No (Score: {PerformanceScore})";
            return $"Name: {Name} | Contract: {Contract} | Salary: {CalculateMonthlyPay():C}\nPerformance Bonus Applied: {bonusApplied}";
        }
    }
}
