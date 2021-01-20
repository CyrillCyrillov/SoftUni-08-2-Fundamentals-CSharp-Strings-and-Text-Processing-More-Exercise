using System;
using System.Linq;
using System.Text;

namespace Task04_Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] morseCode = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            var mesage = new StringBuilder();
            
            for (int i = 0; i < morseCode.Length; i++)
            {
                //string s = (GetSymbol(morseCode[i]);
                mesage.Append(GetSymbol(morseCode[i]));
            }
            
            Console.WriteLine(mesage);
        }

        private static string GetSymbol(string nextMorse)
        {
            string result = string.Empty;
            if(nextMorse.Length == 1)
            {
                switch (nextMorse)
                {
                    case "-":
                        result = "T";
                        break;
                    case ".":
                        result = "E";
                        break;
                    case "|":
                        result = " ";
                        break;
                }
            }
            else if(nextMorse.Length == 2)
            {
                switch (nextMorse)
                {
                    case ".-":
                        result = "A";
                        break;
                    case "..":
                        result = "I";
                        break;
                    case "--":
                        result = "M";
                        break;
                    case "-.":
                        result = "N";
                        break;
                }
            }
            else if (nextMorse.Length == 3)
            {
                switch (nextMorse)
                {
                    case "-..":
                        result = "D";
                        break;
                    case "--.":
                        result = "G";
                        break;
                    case "-.-":
                        result = "K";
                        break;
                    case "---":
                        result = "O";
                        break;
                    case ".-.":
                        result = "R";
                        break;
                    case "...":
                        result = "S";
                        break;
                    case "..-":
                        result = "U";
                        break;
                    case ".--":
                        result = "W";
                        break;
                }
            }
            else if (nextMorse.Length == 4)
            {
                switch (nextMorse)
                {
                    case "-...":
                        result = "B";
                        break;
                    case "-.-.":
                        result = "C";
                        break;
                    case "..-.":
                        result = "F";
                        break;
                    case "....":
                        result = "H";
                        break;
                    case ".---":
                        result = "J";
                        break;
                    case ".-..":
                        result = "L";
                        break;
                    case ".--.":
                        result = "P";
                        break;
                    case "--.-":
                        result = "Q";
                        break;
                    case "...-":
                        result = "V";
                        break;
                    case "-..-":
                        result = "X";
                        break;
                    case "-.--":
                        result = "Y";
                        break;
                    case "--..":
                        result = "Z";
                        break;
                }
            }

            return result;
        }
    }
}
