using System;

namespace Task01_Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string data = Console.ReadLine();
                string name = GetInfo(data, '@', '|');
                string age = GetInfo(data, '#', '*');

                Console.WriteLine($"{name} is {age} years old.");

            }

        }

        private static string GetInfo(string data, char start, char end)
        {
            int startIndex = data.IndexOf(start.ToString());
            int endIndex = data.LastIndexOf(end.ToString());
            string result = string.Empty;

            for (int i = startIndex + 1; i < endIndex; i++)
            {
                result += data[i];
            }
            
            return result;
        }
    }
}
