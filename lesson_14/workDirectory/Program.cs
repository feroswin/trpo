using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace workDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirName = "E:\\";
            // если папка существует
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            

            string[] dirs2 = Directory.GetDirectories(dirName, "н*");
            foreach (string s in dirs2)
            {
                Console.WriteLine("Фильтрация папок " + s + "\n");
            }


            Console.WriteLine("Создание папки");

            string path = @"E:\SomeDir";
            string subPath = @"program\123";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
                directoryInfo.Create();

            directoryInfo.CreateSubdirectory(subPath);

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
                Console.WriteLine("Каталог удален");

            }
            else
                Console.WriteLine("Каталог не существует");

            Console.ReadKey();
        }
    }
}
