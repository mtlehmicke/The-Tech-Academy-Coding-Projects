using System;
using System.Security.Cryptography.X509Certificates;

namespace AgeDateCheck
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How many years old are you?");

            try
            {
                int TheAge = Convert.ToInt32(Console.ReadLine());

                if (TheAge == 0)
                {
                    throw new ArgumentNullException();
                }
                if (TheAge < 0)
                {
                    throw new ArgumentException();
                }

                int TheYear = 2020 - TheAge;

                Console.WriteLine("You were born in the year " + TheYear + ".");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You are not a newborn, enter your real birth year!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You are not from the future, enter your real birth year!");
            }
            catch (Exception)
            {
                    Console.WriteLine("Something went wrong.");
            }
            
        }
    }
}
