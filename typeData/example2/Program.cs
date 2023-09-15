using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных
            int n = 5;
            string[] a = new string[n];
            string str;
            int i;

            // Присвоение значений переменнным
            a[0] = "Миссисипи";
            a[1] = "Нил";
            a[2] = "Амазонка";
            a[3] = "Енисей";
            a[4] = "Белая";
            str = "";


            // Производим конкатенацию строк добавляя после каждого элемента массива символ перевода каретки
            for (i = 0; i < n; i++)
            {
                str += a[i] + "\n"; 
            }

            // Вывод строки
            Console.WriteLine(str);
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();

        }
    }
}
