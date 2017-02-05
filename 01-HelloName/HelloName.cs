using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BlankReceipt
{
    class HelloName
    {
        static void Main()
        {

            var name = GetUserName();
            Console.WriteLine($"Hello, {name}!");
            
        }

        static string GetUserName()
        {
            var name = Console.ReadLine();
            return name;
        }
    }
}
