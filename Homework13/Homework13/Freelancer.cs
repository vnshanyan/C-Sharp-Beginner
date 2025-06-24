using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public class Freelancer: Employee
    {
        public List<Project> Projects { get; set; } = new List<Project>();

        public Freelancer(string name) 
        {
            Name = name;
            Contract = ContractType.Freelancer;
        }
        public override decimal CalculateMonthlyPay()
        {
            decimal salary = 0;
            for(int i = 0; i < Projects.Count; i++)
            {
                if (Projects[i].IsCompleted)
                {
                    salary += Projects[i].Fee;
                }
            }
            return salary;
        }

        public override string GetSummary()
        {
            string projectInfo = string.Join(", ", Projects
            .Where(p => p.IsCompleted)
            .Select(p => $"{p.Title} ({p.Fee:C})"));

            return $"Name: {Name} | Contract: {Contract} | Salary: {CalculateMonthlyPay():C}\nProjects: {projectInfo}";
        }
    }
}
