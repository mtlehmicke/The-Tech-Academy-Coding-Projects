using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            int rate1 = 20;
            int rate2 = 30;
            int hours1 = 40;
            int hours2 = 40;
            int salary1 = rate1 * hours1;
            int salary2 = rate2 * hours2;

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(rate1);

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(hours1);

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);

            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate?");
            Console.WriteLine(rate2);

            Console.WriteLine("Hours worked per week?");
            Console.WriteLine(hours2);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salary1 > salary2);
        }
    }
}
