using System;
using System.Collections.Generic;
using System.Transactions;

namespace VarChainConst
{
    public class Person
    {
        public Person()
        {
            Employee = new List<Person>();
        }

        public Person(string firstName)
            : this()
        {
            this.FirstName = firstName;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            this.LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public IEnumerable<Person> Employee { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int ConstVariable = 9;

            var VarVariable = "Yabba Dabba Doo!";


        }
    }
}
