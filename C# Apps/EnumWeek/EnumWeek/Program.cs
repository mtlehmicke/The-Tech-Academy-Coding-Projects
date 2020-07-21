using System;

namespace EnumWeek
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week:");

                string CurrentDay = Console.ReadLine();

                TheWeek DayOfWeek = (TheWeek)Enum.Parse(typeof(TheWeek), CurrentDay, true);

                switch (DayOfWeek)
                {
                    case TheWeek.Sunday:
                        Console.WriteLine("Today is " + DayOfWeek);
                        break;
                    case TheWeek.Monday:
                        Console.WriteLine("Today is " + DayOfWeek);
                        break;
                    case TheWeek.Tuesday:
                        Console.WriteLine("Today is " + DayOfWeek);
                        break;
                    case TheWeek.Wednesday:
                        Console.WriteLine("Today is Wednesday!");
                        break;
                    case TheWeek.Thursday:
                        Console.WriteLine("Today is Thursday!");
                        break;
                    case TheWeek.Friday:
                        Console.WriteLine("Today is Friday!");
                        break;
                    case TheWeek.Saturday:
                        Console.WriteLine("Today is Saturday!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
        }

        public enum TheWeek
        {
            Sunday=1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
