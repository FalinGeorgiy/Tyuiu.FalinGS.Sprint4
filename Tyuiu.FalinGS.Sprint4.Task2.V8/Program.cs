using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint4.Task2.V8.Lib;

namespace Tyuiu.FalinGS.Sprint4.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №4                                                               #");
            Console.WriteLine("* Задание №2                                                              #");
            Console.WriteLine("* Вариант №8                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Random rnd = new Random();
            DataService ds = new DataService();

            int len = 11;

            int[] numsArray = new int[len];

            for(int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 7);
            }

            Console.WriteLine("Massive");
            for(int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            int res = ds.Calculate(numsArray);

            Console.WriteLine("Summ nechet elements massiva: " + res);


            
            Console.ReadKey();
        }
    }
}
