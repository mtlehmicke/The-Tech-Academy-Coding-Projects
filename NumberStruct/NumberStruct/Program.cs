using System;

namespace NumberStruct
{
    class Program
    {
        struct Number
        {
            public decimal Amount;
        }
        static void Main()
        {
            Number Number1;

            Number1.Amount = 3;

            Console.WriteLine(Number1.Amount);
        }
    }
}
