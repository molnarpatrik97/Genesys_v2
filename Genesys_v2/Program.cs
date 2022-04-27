using System;
using System.Collections.Generic;
using System.Globalization;

namespace Genesys_v2
{
    public class Program
    {
        private static readonly Dictionary<string, string> PhoneButtons = new Dictionary<string, string>
        {
           {"2", "abc" },
           {"3", "def" },
           {"4", "ghi" },
           {"5", "jkl" },
           {"6", "mno" },
           {"7", "pqrs" },
           {"8", "tuv" },
           {"9", "wxyz" },
        };

        public static List<string> LetterGenerator(string digits)
        {
            List<string> result = new List<string> { string.Empty };

            for (int i = 0; i < digits.Length; i++)
            {
                List<string> tmp = new List<string>();
                foreach (string item in result)
                {
                    string letters = PhoneButtons[digits[i].ToString()];
                    for (int j = 0; j < letters.Length; j++)
                    {
                        tmp.Add(item + letters[j]);
                    }
                }
                result = tmp;
            }            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return result;
        }
        public static string Checker()
        {
            Console.WriteLine("Enter a number up to 4 digits. You can use the digits between 2 and 9");
            string digits = Console.ReadLine();
            for (int i = 0; i < digits.Length; i++)
            {
                while (int.Parse(digits[i].ToString()) <= 1)
                {
                    Console.WriteLine("Enter a number up to 4 digits. You can use the digits between 2 and 9");
                    digits = Console.ReadLine();
                    while (digits.Length >= 4)
                    {
                        Console.WriteLine("Enter a number up to 4 digits. You can use the digits between 2 and 9");
                        digits = Console.ReadLine();
                    }
                }
            }
            return digits;
        
        }
        static void Main(string[] args)
        {
            LetterGenerator(Checker());
        }
    }
}
