using System;

namespace PersonSayName
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;        
    }

    class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
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
