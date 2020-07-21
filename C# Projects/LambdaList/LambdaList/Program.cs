using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaList
{
    class Program
    {
        public class Employee
        {
            public string FirstName;
            public string LastName;
            public int ID;
        }
        static void Main()
        {
            List<Employee> EmployeeList = new List<Employee>()
            {
            new Employee() { FirstName = "Abel", LastName = "Wright", ID = 1 },
            new Employee() { FirstName = "Jane", LastName = "Harris", ID = 2 },
            new Employee() { FirstName = "Joe", LastName = "Doe", ID = 3 },
            new Employee() { FirstName = "Doris", LastName = "Lindt", ID = 4 },
            new Employee() { FirstName = "Joe", LastName = "Schmoe", ID = 5 },
            new Employee() { FirstName = "Carla", LastName = "Grant", ID = 6 },
            new Employee() { FirstName = "Jacob", LastName = "Rand", ID = 7 },
            new Employee() { FirstName = "Emily", LastName = "Baron", ID = 8 },
            new Employee() { FirstName = "Charles", LastName = "Vern", ID = 9 },
            new Employee() { FirstName = "Abel", LastName = "Wright", ID = 10 },
            };

            List<Employee> ForEachEmployeeList = new List<Employee>()
            {

            };

            foreach (var Employee in EmployeeList)
            {
                if (Employee.FirstName.Contains("Joe"))
                {
                    ForEachEmployeeList.Add(Employee);
                }
                Console.WriteLine();
            }

            List<Employee> LambdaEmployeeList = EmployeeList
                .Where(Employee => Employee.FirstName == "Joe")
                .ToList();

            List<Employee> IDEmployeeList = EmployeeList
                .Where(Employee => Employee.ID > 5)
                .ToList();
        }
    }
}
