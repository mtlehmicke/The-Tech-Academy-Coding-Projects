using System;

namespace MethodApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("There are three methods in this program, each of which performs a math operation upon an integer. Enter an integer for the first method:");
            Class1.MethodOne(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter an integer for the second method:");
            Class1.MethodTwo(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Enter an integer for the third method:");
            Class1.MethodThree(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
