using System;

namespace ApproveInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int driverAge = 42;
            bool drunkDriver = false;
            int speedingTickets = 2;
            bool getLicense = (driverAge > 15 && speedingTickets < 3 && drunkDriver == false);

            Console.WriteLine("What is your age?");
            Console.WriteLine(driverAge);

            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine(drunkDriver);

            Console.WriteLine("How many speeding tickets do you have?");
            Console.WriteLine(speedingTickets);

            Console.WriteLine("Qualified?");
            Console.WriteLine(getLicense);
        }
    }
}
