using System;

namespace AgeDateCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int TheAge = Convert.ToInt32(Console.ReadLine());
                if (TheAge == 0)
                {
                    throw new Exception("You are not a newborn, enter your real birth year!");
                }
                if (TheAge < 0)
                {
                    throw new Exception("You are not from the future, enter your real birth year!");
                }
                int TheYear = 2020 - TheAge;
                
                Console.WriteLine("You were born in the year " + TheYear + ".");
            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong.")
            }
        }
    }
}
