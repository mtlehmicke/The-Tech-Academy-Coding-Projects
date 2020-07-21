using System;

namespace WhileDoWhileApp
{
    class Program
    {
        static void Main()
        {
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 11);

            while (i < 100)
            {
                Console.WriteLine(i);
                i = i + 5;
                Console.ReadLine();
            }
        }
    }
}
