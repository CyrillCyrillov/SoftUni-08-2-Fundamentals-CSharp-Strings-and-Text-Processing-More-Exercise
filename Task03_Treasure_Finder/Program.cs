using System;
using System.Linq;
using System.Text;

namespace Task03_Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while (true)
            {
                string code = Console.ReadLine();
                if (code.ToUpper() == "FIND")
                {
                    break;
                }

                int keyIndex = 0;

                var sb = new StringBuilder();

                for (int i = 0; i < code.Length; i++)
                {
                    char newChar = (char)(code[i] - key[keyIndex]);
                    sb.Append(newChar);
                    keyIndex++;
                    if(keyIndex > key.Length - 1)
                    {
                        keyIndex = 0;
                    }
                }

                string deCode = sb.ToString();

                //Console.WriteLine(deCode);

                string type = GetInfo(deCode, '&', '&');
                string coordinates = GetInfo(deCode, '<', '>');

                Console.WriteLine($"Found {type} at {coordinates}");

            }
            
        }

        private static string GetInfo(string deCode, char start, char end)
        {
            int startIndex = deCode.IndexOf(start);
            int endIndex = deCode.LastIndexOf(end);
            var sb = new StringBuilder();
            
            for (int i = startIndex + 1; i <= endIndex - 1; i++)
            {
                sb.Append(deCode[i]);
            }
            
            return sb.ToString();
        }
    }
}
