using System;

namespace QuitTableApp
{
    interface IQuittable
    {
        void Quit();
    }
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("The employee has quit the company.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee heQuits = new Employee();
            heQuits.Quit();
        }
    }
}
