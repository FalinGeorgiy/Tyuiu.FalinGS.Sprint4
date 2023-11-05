using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint4.Task1.V28.Lib;

namespace Tyuiu.FalinGS.Sprint4.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №4                                                               #");
            Console.WriteLine("* Задание №1                                                              #");
            Console.WriteLine("* Вариант №28                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            DataService ds = new DataService();

            int len = 14;

            int[] numsArray = new int[len];

            for (int i = 0; i<= len-1; i++)
            {
                Console.Write("Vedite znachenie" + i + "element massiva: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine();
            Console.WriteLine("Massive: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            int res = ds.Calculate(numsArray);

            



            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
