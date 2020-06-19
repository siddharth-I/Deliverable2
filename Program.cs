using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word.");

            String input = Console.ReadLine();

            String upperInput = input.ToUpper();

            foreach (char c in upperInput)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
