using System;
using System.Collections.Generic;

namespace TryCatchIntegers
{
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>
            {
                12,
                24,
                36,
                42,
                58,
                64,
            };
                        
            try
            {
                Console.WriteLine("Enter an integer to divide by:");
                int divNum = Convert.ToInt32(Console.ReadLine());

                foreach (int id in intList)
                {
                    double divNum2 = Convert.ToDouble(id / divNum);
                    Console.WriteLine(divNum2);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine("Program has completed.");
        }
    }
}