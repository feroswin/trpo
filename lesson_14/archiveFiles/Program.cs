using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Diagnostics;

namespace archiveFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sourceFile = "book.pdf"; // исходный файл
            string compressedFile = "book.gz"; // сжатый файл
            string targetFile = "book_new.pdf"; // восстановленный файл

            CompressAsync(sourceFile, compressedFile);
            // чтение из сжатого файла
            DecompressAsync(compressedFile, targetFile);



            string sourceFolder = @"E:\test\"; // исходная папка
            string zipFile = @"E:\test.zip"; // сжатый файл
            string targetFolder = @"E:\newtest"; // папка, куда распаковывается файл

            ZipFile.CreateFromDirectory(sourceFolder, zipFile);
            Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
            ZipFile.ExtractToDirectory(zipFile, targetFolder);

            Console.WriteLine($"Файл {zipFile} распакован в папку {targetFolder}");

        }

        static void CompressAsync(string sourceFile, string compressedFile)
        {
            // поток для чтения исходного файла
            FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate);
            // поток для записи сжатого файла
            FileStream targetStream = File.Create(compressedFile);

            // поток архивации
            GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress);
            sourceStream.CopyToAsync(compressionStream); // копируем байты из одного потока в другой

            Console.WriteLine($"Сжатие файла {sourceFile} завершено.");
            Console.WriteLine($"Исходный размер: {sourceStream.Length}  сжатый размер: {targetStream.Length}");
        }

        static void DecompressAsync(string compressedFile, string targetFile)
        {
            // поток для чтения из сжатого файла
            FileStream sourceStream = new FileStream(compressedFile, FileMode.OpenOrCreate);
            // поток для записи восстановленного файла
            FileStream targetStream = File.Create(targetFile);
            // поток разархивации
            GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress);
            decompressionStream.CopyToAsync(targetStream);
            Console.WriteLine($"Восстановлен файл: {targetFile}");
        }
    }
}
