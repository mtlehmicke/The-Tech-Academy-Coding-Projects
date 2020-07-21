using System;

namespace PersonClassApp
{
    class Person
    {
        public string FirstName = "Max";
        public string LastName = "Lehmicke";

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    class Employee : Person
    {
        int ID;
    }

    class Program
    {
        static void Main()
        {
            Employee newEmp = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            newEmp.SayName();
        }
    }
}
