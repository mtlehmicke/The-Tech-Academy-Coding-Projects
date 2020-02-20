using System;

namespace ConsoleMath
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer to be multiplied by 50:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 * 50);

            Console.WriteLine("Enter an integer to add 25 to:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 + 25);

            Console.WriteLine("Enter an integer to divide by 12.5:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3 / 12.5);

            Console.WriteLine("Enter an integer to find if it is greater than 50:");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num4 > 50);

            Console.WriteLine("Enter an integer to divide by 7 and find the remainder:");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num5 % 7);
        }
    }
}
