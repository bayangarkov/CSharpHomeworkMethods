using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_TrickyStringBroken
{
    class TrickyStringBroken
    {
        static void Main()
        {
            var delimiter = Console.ReadLine();

            var numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;

            var currentString = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                currentString = Console.ReadLine();

                if (i == (numberOfStrings - 1))
                {
                    result += currentString;
                }
                else
                {
                    result = result + currentString + delimiter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
