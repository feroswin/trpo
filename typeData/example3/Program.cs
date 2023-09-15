using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем переменные
            double[] a = new double[] { -8, 13, 26, 14, 17, 21, -34, 28 };
            int n = a.Length;
            string str;
            int i;
            double sum = 0;
            double avg;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]); // Выводим элемент массива
                sum += a[i]; // Суммируем элементы массива
            }

            // Вычисляем ср. арифметическое
            avg = sum / n;

            // Делаем конкатенацию для лучшей визуализации
            str = "Сумма массива равна " + sum + "\nСреднее арифметическое массива равно  " + avg; 
            
            // Вывод результата программы
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
