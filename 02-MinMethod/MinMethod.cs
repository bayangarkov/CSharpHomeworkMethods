using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MinMethod
{
    class MinMethod
    {
        static void Main()
        {

            var result = FindMaxValue();
            Console.WriteLine(result);
        }

        static int FindMaxValue()
        {
            var minValue = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                var input = int.Parse(Console.ReadLine());

                if (input < minValue)
                {
                    minValue = input;
                }
            }

            return minValue;
        }
    }
}
