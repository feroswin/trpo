using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "note1.txt";
            string text = "Hello World\nHello METANIT.COM";

            // полная перезапись файла 
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(text);
            }
            // добавление в файл
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("Addition");
                writer.Write("4,5");
            }


            string path2 = @"E:\test.php";

            // асинхронное чтение
            using (StreamReader reader = new StreamReader(path2))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.ReadKey();
        }
    }
}
