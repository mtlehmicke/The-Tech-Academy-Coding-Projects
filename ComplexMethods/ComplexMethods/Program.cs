using System;

namespace ComplexMethods
{
    class Program
    {
        static class firstClass
        {
            public static void DivMethod(double x)
            {
                Console.WriteLine(x / 2);
            }
            public static void DivMethod(int x, out int y, out int z)
            {
                y = 10;
                z = 3;
                Console.WriteLine(x * y * z);
            }
        }
        static void Main()
        {
            double theDouble = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entern an integer:");
            firstClass.DivMethod(theDouble);
        }
    }
}
