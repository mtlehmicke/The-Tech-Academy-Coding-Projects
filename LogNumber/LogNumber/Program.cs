using System;
using System.IO;

namespace LogNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string TheNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Logs\log.txt", TheNumber);

            string TheText = File.ReadAllText(@"C:\Users\Student\Logs\log.txt");
            Console.WriteLine(TheText);
        }
    }
}
