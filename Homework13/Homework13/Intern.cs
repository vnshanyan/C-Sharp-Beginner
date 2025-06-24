using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public class Intern: Employee, IPerformanceEvaluated
    {
        public decimal MonthlyStipend { get; set; }
        public int Grade { get; set; }
        public int PerformanceScore
        {
            get => Grade;
            set => Grade = value;
        }

        public Intern(string name, decimal stipend, int grade)
        {
            Name = name;
            MonthlyStipend = stipend;
            Grade = grade;
            Contract = ContractType.Intern;
        }
        public override decimal CalculateMonthlyPay()
        {
            return Grade < 50 ? 0 : MonthlyStipend;
        }
        public override string GetSummary()
        {
            string warning = Grade < 50 ? "Warning: Underperforming Intern" : string.Empty;
            return $"Name: {Name} | Contract: {Contract} | Grade: {Grade} | Stipend: {CalculateMonthlyPay():C}" +
                   (string.IsNullOrWhiteSpace(warning) ? "" : $"\n{warning}");
        }
    }
}
