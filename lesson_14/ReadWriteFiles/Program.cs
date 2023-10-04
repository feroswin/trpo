using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWriteFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\test.php";   // путь к файлу

            string text = "Hello METANIT.COM"; // строка для записи

            // запись в файл
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.WriteAsync(buffer, 0, buffer.Length);
                Console.WriteLine("Текст записан в файл");
            }

            // чтение из файла
            using (FileStream fstream = File.OpenRead(path))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }


            string path2 = "note2.dat";

            string text2 = "hello world";

            // запись в файл
            using (FileStream fstream = new FileStream(path2, FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] input = Encoding.Default.GetBytes(text2);
                // запись массива байтов в файл
                fstream.Write(input, 0, input.Length);
                Console.WriteLine("Текст записан в файл");
            }
            using (FileStream fstream = new FileStream(path2, FileMode.OpenOrCreate))
            {
                // заменим в файле слово world на слово house
                string replaceText = "house";
                fstream.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока
                byte[] input = Encoding.Default.GetBytes(replaceText);
                fstream.WriteAsync(input, 0, input.Length);

                // считываем весь файл
                // возвращаем указатель в начало файла
                fstream.Seek(0, SeekOrigin.Begin);
                byte[] output = new byte[fstream.Length];
                fstream.ReadAsync(output, 0, output.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(output);
                Console.WriteLine($"Текст из файла: {textFromFile}"); // hello house
            }

            Console.ReadKey();
        }
    }
}
