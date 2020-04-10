using System;

namespace OperatorOverload
{
    class Person
    {
        public string FirstName = "Max";
        public string LastName = "Lehmicke";
    }

    class Employee : Person
    {
        public int ID = 12345;

        public static bool operator ==(Employee leftID, Employee rightID)
        {
            return true;
        }

        public static bool operator !=(Employee leftID, Employee rightID)
        {
            return !(leftID == rightID);
        }
    }

    class Program
    {
        static void Main()
        {
            Employee defaultEmp = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                ID = 12345
            };

            Employee newEmp = new Employee()
            {
                FirstName = "Example",
                LastName = "Student",
                ID = 12345
            };

        }
    }
}