using System;

namespace ShippingQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of your package in lbs.");
            float packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight < 50)
            {
                Console.WriteLine("Please enter the width of your package in inches.");
                float packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the height of your package in inches.");
                float packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the length of your package in inches.");
                float packageLength = Convert.ToInt32(Console.ReadLine());

                float packageSize = packageWidth + packageHeight + packageLength;

                float packageTotal = (packageWeight * packageWidth * packageHeight * packageLength) / 100;

                if (packageSize > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.Have a good day.");
                }

                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packageTotal);
                    Console.WriteLine("Thank you.");
                }

            }

            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            }
        }
    }
}
