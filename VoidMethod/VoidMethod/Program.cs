using System;

namespace VoidMethod
{
    class Program
    {
        class theMethod
        {
            public static void MethodMath(int x, int y)
            {
                int z = x + 77;
                Console.WriteLine(y);
            }
        }
        static void Main()
        {
            theMethod.MethodMath(10, 15);

            theMethod.MethodMath(x: 15, y: 72);
        }
    }
}
