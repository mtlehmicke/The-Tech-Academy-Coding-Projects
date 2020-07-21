using System;

namespace InstantiateMethodApp
{
    class Program
    { 
        static void Main()
        {
            Console.WriteLine("Enter a decimal to divide by three.");
            decimal theInteger = theMethods.MethodMath(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine(theInteger);

            Console.WriteLine("Enter a decimal to divide by three.");
            decimal theDecimal = theMethods.MethodMath(Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine(theDecimal);

            Console.WriteLine("Enter a string to multiply by ten, if possible.");
            string theString = theMethods.MethodMath(Console.ReadLine());
            Console.WriteLine(theString);
        }
    }
}
