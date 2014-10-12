using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S01.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
                int b = i % 3;
                switch (b)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
                if (i % 2 > 0)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 39; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();  
        }
    }
}
