using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormationsDebug
{
    class TriangleFormation
    {
        static void Main()
        {
            var sideA = int.Parse(Console.ReadLine());
            var sideB = int.Parse(Console.ReadLine());
            var sideC = int.Parse(Console.ReadLine());
            

            var isValidTriangle = (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideA + sideC > sideB);

            if (isValidTriangle)
            {
                Console.WriteLine("Triangle is valid.");
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
                return;
            }

            var rightTriangleCondition1 = Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);
            var rightTriangleCondition2 = Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2);
            var rightTriangleCondition3 = Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2);

            if (rightTriangleCondition1)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }                
            else if (rightTriangleCondition2)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            } 
            else if (rightTriangleCondition3)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
            }
                
        }
    }
}
