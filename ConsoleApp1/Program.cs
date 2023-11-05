using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] array = new int[] { 2, 4, 3, 7, 5, 2, 3 };
               
                int p = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                        {
                        p *= array[i];
                        }
                        
                }
                
                Console.WriteLine(p);
            Console.ReadKey();
            }
    }
}
