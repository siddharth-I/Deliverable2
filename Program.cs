using System;
using System.Threading;

namespace Deliverable2
{
    class Program
    {
        static void Main()
        {
            string input;
            string message1;
            string message = "Your encoded message is ";
            int checksum = 0;
            string final = "Message checksum is ";
            Console.WriteLine("What is your message?");

            input = Console.ReadLine();

            string upperInput = input.ToUpper();

            char[] charArr = upperInput.ToCharArray();



            foreach (char ch in charArr)
            {
                string val = (Convert.ToInt32(ch) - 64).ToString();
                message1 = val + "-";
                message = message + message1;
            }

            Console.WriteLine(message);

            foreach (char ch in charArr)
            {
                checksum = checksum + (Convert.ToInt32(ch));
                final = "Message checksum is " + checksum.ToString();
            }

            Console.Write(final);
        }
    }
}
