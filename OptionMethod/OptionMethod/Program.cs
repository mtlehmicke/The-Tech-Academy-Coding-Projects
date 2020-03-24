using System;

namespace OptionMethod
{
    class Program
    {
        class theMethod
        {
            public static int MethodMath(int x, int y = 10)
            {
                return x + y;
            }
        }

        static void Main()
        {
            Console.WriteLine("This program adds two integers. You may enter two, but only the first is necessary. If you do not enter a second integer then it will default to ten. Pick a number:");
            int theX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number--optional");
            int theY;
            int theResult;

            if (int.TryParse(Console.ReadLine(), out theY))
                theResult = theMethod.MethodMath(theX, theY);
            else
                theResult = theMethod.MethodMath(theX);

            Console.WriteLine(theResult);

        }
    }
}
