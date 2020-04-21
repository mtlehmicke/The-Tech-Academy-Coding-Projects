using System;

namespace PrintDateHour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It is currently " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

            Console.WriteLine("Please enter a number:");

            Console.WriteLine(DateTime.Now.AddHours(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
