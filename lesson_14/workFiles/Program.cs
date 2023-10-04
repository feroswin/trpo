using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace workFiles
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            string path = @"E:\test.js";
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists )
            {
                Console.WriteLine($"Имя: {fileInfo.Name}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length}");
            }

            FileInfo fileInfo1 = new FileInfo("E:\\test.txt");

            fileInfo1.Create();
            if (fileInfo1.Exists )
            {
                fileInfo1.Delete();
                Console.WriteLine("файл удален");
            }

            string newPath = @"E:\Новая папка\test.txt";
            FileInfo newFileInfo = new FileInfo(path);
            if ( newFileInfo.Exists )
            {
                newFileInfo.CopyTo(newPath , true);
                Console.WriteLine("файл скопирован");
            }

            Console.ReadKey();
        }
    }
}
