
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> 
            {
                new FullTimeEmployee("Anun1", 4000, 500, 92),
                new FullTimeEmployee("Anun2", 3800, 400, 76),
                new PartTimeEmployee("Anun3", 80, 20),
                new PartTimeEmployee("Anun4", 60, 22),
                new Freelancer("Anun5")
                {
                    Projects = new List<Project>
                    {
                        new Project { Title = "UiPath Integration", Fee = 1000, IsCompleted = true },
                        new Project { Title = "Kafka Integration", Fee = 800, IsCompleted = true },
                        new Project { Title = "Logo Design", Fee = 300, IsCompleted = false }
                    }
                },
                new Intern("Anun6", 500, 48),
                new Intern("Anun7", 500, 85)
            };

            Console.WriteLine("--- Employee Summary ---");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.GetSummary());
            }

            var highEarners = employees.Where(emp => emp.CalculateMonthlyPay() > 1000);
            var topPerformers = employees.OfType<IPerformanceEvaluated>().Where(emp => emp.PerformanceScore >= 80);

            Console.WriteLine("Employees earning over $1000:");
            foreach (var e in highEarners) 
            {
                Console.WriteLine($"- {e.Name}: {e.CalculateMonthlyPay():C}");
            }

            Console.WriteLine("Top Performers:");
            foreach (var e in topPerformers)
            {
                Console.WriteLine($"- {((Employee)e).Name} (Score: {e.PerformanceScore})");
            }
            ExportToJson(employees, "employees.json");
            ExportToCsv(employees, "employees.csv");
        }
        static void ExportToJson(List<Employee> employees, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() } // Serialize enums as strings
            };

            var json = JsonSerializer.Serialize(employees, options);
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Exported to JSON: {filePath}");
        }
        static void ExportToCsv(List<Employee> employees, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name,ContractType,Salary");

                foreach (var e in employees)
                {
                    string name = e.Name.Replace(",", " ");
                    string contract = e.Contract.ToString();
                    decimal salary = e.CalculateMonthlyPay();

                    writer.WriteLine($"{name},{contract},{salary:F2}");
                }
            }

            Console.WriteLine($"Exported to CSV: {filePath}");
        }
    }
    
    public enum ContractType 
    {
        FullTime,
        PartTime,
        Freelancer,
        Intern
    }
}
/*
===============================
HOMEWORK: Workforce System for HexaTech Corp
===============================

🎯 Objective:
Build a class-based workforce management system for a tech company that hires different types of employees under different contracts. The system should calculate monthly salaries based on contract type and other conditions like performance, projects, or hours worked.

===============================
🔧 Requirements
===============================

1. Enum: ContractType
-------------------------------
Define an enum to represent employee contract types:

enum ContractType
{
    FullTime,
    PartTime,
    Freelancer,
    Intern
}

2. Base Abstract Class: Employee
-------------------------------
Each employee should have:

- Guid Id
- string Name
- ContractType Contract
- Abstract method: decimal CalculateMonthlyPay()
- Abstract method: string GetSummary()

abstract class Employee
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public ContractType Contract { get; protected set; }

    public abstract decimal CalculateMonthlyPay();
    public abstract string GetSummary();
}

3. Derived Classes
-------------------------------

a) FullTimeEmployee
- decimal BaseSalary
- decimal PerformanceBonus
- int PerformanceScore
- If PerformanceScore > 80, include PerformanceBonus in salary.

b) PartTimeEmployee
- int HoursWorked
- decimal HourlyRate

c) Freelancer
- List<Project> Projects
- Each project has Title, Fee, and IsCompleted
- Only completed projects are counted for salary.

d) Intern
- decimal MonthlyStipend
- int Grade (0–100)
- If Grade < 50, stipend is $0.

4. Project Class
-------------------------------
Each freelancer works on one or more projects.

class Project
{
    public string Title { get; set; }
    public decimal Fee { get; set; }
    public bool IsCompleted { get; set; }
}

5. Interface: IPerformanceEvaluated
-------------------------------
interface IPerformanceEvaluated
{
    int PerformanceScore { get; set; }
}

Implement this interface in FullTimeEmployee and Intern.

6. Program.cs Test Logic
-------------------------------
- Create a List<Employee> with 1-2 instances of each employee type.
- Assign projects to freelancers.
- Assign random performance scores to full-time employees and interns.
- Print summary for each employee:
  - Name
  - Contract type
  - Salary
  - Performance status (if applicable)
  - Projects (if freelancer)

7. Bonus Tasks (Optional)
-------------------------------
- Track total payroll for the month.
- Use LINQ to:
  - Filter employees with salary > $1000
  - Find top performer(s)
- Export employee summary to CSV or JSON.

===============================
📘 Sample Output (Console)
===============================

--- Employee Summary ---
Name: Alice | Contract: FullTime | Salary: $4,500.00
Performance Bonus Applied: Yes (Score: 92)

Name: Bob | Contract: Freelancer | Salary: $1,800.00
Projects: API Integration ($1,000), Landing Page ($800)

Name: Clara | Contract: Intern | Grade: 48 | Stipend: $0.00
Warning: Underperforming Intern

Total Payroll: $6,300.00

===============================
📚 Learning Outcomes
===============================
- Use of abstract classes, inheritance, and interfaces
- Real-world contract logic modeling
- Polymorphism and override behavior
- List and LINQ operations
- Console output formatting
- Optional: JSON or CSV export

===============================
📂 Submission
===============================
1. Source files: Employee.cs, Program.cs, Project.cs
2. Screenshot of output
3. Bonus: CSV or JSON file of employees (optional)
*/