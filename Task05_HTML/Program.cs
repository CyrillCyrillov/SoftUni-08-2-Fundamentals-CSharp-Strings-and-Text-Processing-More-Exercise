using System;
using System.Linq;
using System.Collections.Generic;

namespace Task05_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> title = new List<string> { Console.ReadLine() };
            List<string> article = new List<string> { Console.ReadLine() };

            List<string> coments = new List<string>();

            while (true)
            {
                string nextComent = Console.ReadLine();

                if(nextComent.ToLower() == "end of comments")
                {
                    break;
                }

                coments.Add(nextComent);
            }

            WriteHtml(title, "h1");
            WriteHtml(article, "article");
            WriteHtml(coments, "div");
        }

        private static void WriteHtml(List<string> toPrint, string label)
        {
            for (int i = 0; i < toPrint.Count; i++)
            {
                Console.WriteLine($"<{label}>");
                Console.WriteLine($"    {toPrint[i]}");
                Console.WriteLine($"</{label}>");
            }
        }
    }
}
