using System;
using System.Reflection;
using System.Text;

namespace StringApp
{
    class Program
    {
        static void Main()
        {
            string firstPart = "How to ";
            string secondPart = "concatenate ";
            string thirdPart = "a string.";
            string allParts = firstPart + secondPart + thirdPart;
            Console.WriteLine(allParts);

            Console.WriteLine(allParts.ToUpper());

            StringBuilder sb = new StringBuilder("Hello, Tech Academy! ", 50);
            sb.Append("This is a Paragraph! ");
            sb.Append("I made it in C#, ");
            sb.Append("using a StringBuilder!");
            Console.WriteLine(sb);
        }
    }
}
