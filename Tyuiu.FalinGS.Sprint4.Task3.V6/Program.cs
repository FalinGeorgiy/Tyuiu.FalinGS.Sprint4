using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.FalinGS.Sprint4.Task3.V6.Lib;


namespace Tyuiu.FalinGS.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5] { { 8, 8, 3, 4, 5},
                                          { 7, 6, 6, 4, 6},
                                          { 3, 6, 5, 3, 4},
                                          { 5, 6, 3, 7, 5},
                                          { 7, 8, 5, 6, 6}, };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №4                                                               #");
            Console.WriteLine("* Задание №3                                                              #");
            Console.WriteLine("* Вариант №6                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Massive: ");
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j< columns; j++)
                {
                    Console.Write($"{mas[i,j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            int res = ds.Calculate(mas);

            Console.WriteLine("Max element: " + res);



            Console.ReadKey();

        }
    }
}
