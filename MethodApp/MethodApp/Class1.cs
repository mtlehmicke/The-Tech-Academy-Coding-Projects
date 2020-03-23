using System;
using System.Collections.Generic;
using System.Text;

namespace MethodApp
{
    class Class1
    {
        public static int theInteger = Convert.ToInt32(Console.ReadLine());

        public static void MethodOne()
        {
            Console.WriteLine(theInteger + " multiplied by ten equals:");
            Console.WriteLine(theInteger * 10);
        }

        public static void MethodTwo()
        {
            Console.WriteLine(theInteger + " plus fifty equals:");
            Console.WriteLine(theInteger + 50);
        }

        public static void MethodThree()
        {
            Console.WriteLine(theInteger + " divided by three equals:");
            Console.WriteLine(theInteger / 3);
        }
    }
}
