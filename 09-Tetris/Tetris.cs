using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Tetris
{
    class Tetris
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "left":
                        Left(n);
                        break;

                    case "down":
                        Down(n);
                        break;

                    case "right":
                        Right(n);
                        break;

                    case "up":
                        Up(n);
                        break;
                }
                currentDirection = Console.ReadLine();
            }
        }
        

        // methods below

        static void Left(int n) // LEFT
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 2));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n));
            }

        }

       static void Right(int n) // RIGHT
       {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 2));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n) + new string('.', n));
            }
        }
      
       static void Up(int n) // UP
       {
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
           }
      
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine(new string('*', n * 3));
           }
       }
      
       static void Down(int n) // DOWN
       {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n * 3));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
            }
        }
    }
}
