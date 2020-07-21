using System;
using System.Collections.Generic;

namespace ArraysApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer between 0 and 4 to select the array's corresponding element.");
            string[] myLetters = { "A", "B", "C", "D", "E"};
            int letterIndex = int.Parse(Console.ReadLine());

            if (letterIndex < 4)
            {
                Console.WriteLine(myLetters[letterIndex]);
            }
            else
            {
                Console.WriteLine("That is not a valid index.");
            }

            Console.WriteLine("Enter an integer between 0 and 4 to select the array's corresponding element.");
            int[] myNumbers = { 0, 10, 20, 30, 40};
            int numberIndex = int.Parse(Console.ReadLine());

            if (numberIndex < 4)
            { 
            Console.WriteLine(myNumbers[numberIndex]);
            }
            else
            {
                Console.WriteLine("That is not a valid index.");
            }

            List<string> nameList = new List<string>();
            nameList.Add("Tom");
            nameList.Add("Rick");
            nameList.Add("Harry");
            nameList.Add("Jack");
            nameList.Add("Jill");
            Console.WriteLine("Enter an integer between 0 and 4 to select the array's corresponding element.");
            int nameIndex = int.Parse(Console.ReadLine());

            if (nameIndex < 4)
            {
                Console.WriteLine(nameList[nameIndex]);
            }
            else
            {
                Console.WriteLine("That is not a valid index.");
            }

        }
    }
}
