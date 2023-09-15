using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t, i;
            int[,] table = new int[3, 4]; // Создаем двумерный массив 3x4.

            // Внешний цикл для итерации по строкам массива.
            for (t = 0; t < 3; ++t)
            {
                // Внутренний цикл для итерации по столбцам внутри каждой строки.
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1; // Заполняем элемент массива формулой (t * 4) + i + 1.
                    Console.WriteLine(table[t, i] + " "); // Выводим значение элемента на консоль с пробелом.
                }
                Console.WriteLine();
            }

            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
