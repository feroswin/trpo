using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных
            int n = 3;
            int[] a = new int[n];
            string str;
            int i;
            int sum = 0;
            a[0] = 1;
            a[1] = -8;
            a[2] = 14;


            for (i = 0; i < n; i++)
            {
                sum += a[i]; // суммируем элементы массива
            }

            str = "Сумма массива равна " + sum;
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
