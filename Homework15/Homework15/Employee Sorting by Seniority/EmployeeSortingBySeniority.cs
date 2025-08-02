using System;

namespace Homework15
{
    public class EmployeeSortingBySeniority
    {
        //3. Employee Sorting by Seniority
        //------------------------------------------------
        //Topic: IComparable<Employee>
        //Model an `Employee` class:
        //- string FullName
        //- DateTime HireDate
        //- string Position
        //Tasks:
        //- Sort employees by seniority(HireDate ascending).
        //- Bonus: Add enum PositionLevel and use it as a secondary comparison criteria.
        public EmployeeSortingBySeniority()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{FullName = "Anun Azganun - 1", HireDate = DateTime.Now, Position = "Senior", Level = PositionLevel.Senior},
                new Employee{FullName = "Anun Azganun - 2", HireDate = DateTime.MinValue, Position = "Mid", Level = PositionLevel.Mid},
                new Employee{FullName = "Anun Azganun - 3", HireDate = DateTime.MaxValue, Position = "Senior", Level = PositionLevel.Senior},
                new Employee{FullName = "Anun Azganun - 4", HireDate = DateTime.UnixEpoch, Position = "Junior", Level = PositionLevel.Junior},
            };

            employees.Sort();
            foreach (Employee item in employees)
            {
                Console.WriteLine(item.HireDate);
                Console.WriteLine(item.Level);
            }
        }
    }
}
