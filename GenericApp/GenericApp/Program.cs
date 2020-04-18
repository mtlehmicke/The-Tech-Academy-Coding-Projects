using System;
using System.Collections.Generic;

namespace GenericApp
{
    public class Employee<T>
    {
        public List<T> Things;
    }

    class Program
    {
        static void Main()
        {
            Employee<String> EmpString = new Employee<String>();
            EmpString.Things = new List<string> { "Aaron", "Beth", "Charles", "Diane" };

            Employee<int> EmpInt = new Employee<int>();
            EmpInt.Things = new List<int> { 1, 2, 3, 4 };

            foreach (var i in EmpString.Things)
            {
                Console.WriteLine(i);
            }
            foreach (var i in EmpInt.Things)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}