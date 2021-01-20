using System;
using System.Text;

namespace Task02_Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int start = (input[0]); 
            input = Console.ReadLine();
            int end = (input[0]);
            int asciiSum = 0;

            string data = Console.ReadLine();

            for (int i = 0; i <= data.Length - 1; i++)
            {
                if(data[i] > start && data[i] < end)
                {
                    asciiSum += (data[i]);
                }

            }

            
            Console.WriteLine(asciiSum);
        }
    }
}
