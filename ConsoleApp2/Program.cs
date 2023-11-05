using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { -5, 2, -1 }, { -11, 7, 8 }, { 7, -3, 8 } };
            int s = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        s += array[i, j];
                    }
                }

            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
