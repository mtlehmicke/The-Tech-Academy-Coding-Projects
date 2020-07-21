using System;
using System.Collections.Generic;
using System.Text;

namespace MethodApp
{
    class Class1
    {

        public static void MethodOne(int x)
        {
            Console.Write(x + " multiplied by ten equals: ");
            Console.WriteLine(x * 10);
        }

        public static void MethodTwo(int x)
        {
            Console.Write(x + " plus fifty equals: ");
            Console.WriteLine(x + 50);
        }

        public static void MethodThree(int x)
        {
            Console.Write(x + " divided by three equals: ");
            Console.WriteLine(x / 3);
        }
    }
}
