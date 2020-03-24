using System;

namespace InstantiateMethodApp
{
    class Program
    { 
        class theMethods
        {
            public static int MethodMath(int x)
            {                
                return x + 10;
            }

            public static decimal MethodMath(decimal x)
            {
                return x * 3;
            }
            public static string MethodMath(string x)
            {
                int y = Convert.ToInt32(x) * 10;
                return Convert.ToString(y);
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter a decimal to divide by three.");
            decimal theDecimal = theMethods.MethodMath(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine(theDecimal);

            Console.WriteLine("Enter a string to multiply by ten, if possible.");
            string theString = theMethods.MethodMath(Console.ReadLine());
            Console.WriteLine(theString);
        }
    }
}
