using System;

namespace CustomException
{
    class Program
    {
        public static void DoSomething(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            Console.WriteLine($"The number is {number}.");
        }
        static void Main(string[] args)
        {
                try
                {
                    DoSomething(-1);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"An exception occurred: {ex.Message}");
                }
        }    
    }    
}
