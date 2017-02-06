using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            var inputNum = int.Parse(Console.ReadLine());
            var inputIndex = int.Parse(Console.ReadLine());

            var showNthDigit = FindNthDigit(inputNum,inputIndex);

            Console.WriteLine(showNthDigit);
            
        }

        static int FindNthDigit(int inputNum, int inputIndex)
        {
            var loopCounter = 0;

            double result = 0;

            while (inputNum > 0)
            {

                var digit = inputNum % 10;

                loopCounter += 1;

                if (inputIndex == loopCounter)
                {
                    result = digit;
                    break;
                }
                else
                {
                    inputNum = inputNum / 10;
                }

            }

            return (int)result;
        }
    }
}
