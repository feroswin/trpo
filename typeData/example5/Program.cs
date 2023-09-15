using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    internal class Program
    {

        static void print(int[] alpha)
        {
            foreach (int i in alpha)
                Console.WriteLine(i + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Инициализируем массив
            int[] alpha = { -4, 8, 28, -6, -98, -47, 12 };
            
            //Отобразить исходный массив
            Console.WriteLine("Исходный массив ...");
            print(alpha);

            //Найти значение 8
            int pattern = 8;
            int indx = Array.BinarySearch(alpha, pattern);
            Console.WriteLine("Индекс элемента массива со значением 8: " + indx);

            //Сортируем массив
            Array.Sort(alpha);
            Console.WriteLine("Сортировка по возрастанию ...");
            //Отображаем массив после сортировки
            print(alpha);

            //Сортируем массив по убыванию
            Array.Reverse(alpha);
            //Отображаем массив после сортировки по убыванию
            Console.WriteLine("Сортировка по убыванию ...");
            print(alpha);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
