using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            var inputText = Console.ReadLine();
            var counter = int.Parse(Console.ReadLine());

            var result = RepeatString(inputText, counter);

            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }
    }
}
