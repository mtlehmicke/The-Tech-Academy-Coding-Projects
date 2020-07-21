using System;

namespace ComplexMethods
{
    class Program
    {
        static class firstClass
        {
            public static void DupMethod(int x)
            {
                Console.WriteLine(x * 2);
            }
            public static void DupMethod(double x)
            {
                Console.WriteLine(x / 2);
            }
            public static void OutMethod(int x, out int y, out int z)
            {
                y = 10;
                z = 3;
                Console.WriteLine(x * y * z);
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter an integer:");
            double theInteger = Convert.ToInt32(Console.ReadLine());
            firstClass.DupMethod(theInteger);

            Console.WriteLine("Enter a double:");
            double theDouble = Convert.ToDouble(Console.ReadLine());
            firstClass.DupMethod(theDouble);

            Console.WriteLine("Enter another integer:");
            int theOut = Convert.ToInt32(Console.ReadLine());
            firstClass.DupMethod(theOut);
        }
    }
}
