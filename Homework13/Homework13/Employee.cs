using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    public abstract class Employee
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public ContractType Contract { get; protected set; }
        public abstract decimal CalculateMonthlyPay();
        public abstract string GetSummary();
    }
}
