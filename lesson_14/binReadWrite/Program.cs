using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binReadWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "people.dat";

            // массив для записи
            Person[] people =
            {
                new Person("Tom", 37),
                new Person("Bob", 41)
            };

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                // записываем в файл значение каждого свойства объекта
                foreach (Person person in people)
                {
                    writer.Write(person.Name);
                    writer.Write(person.Age);
                }
                Console.WriteLine("File has been written");
            }

            // список для считываемых данных
            List<Person> people2 = new List<Person>();

            // создаем объект BinaryWriter
            using (BinaryReader reader = new BinaryReader(File.Open("people.dat", FileMode.Open)))
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while (reader.PeekChar() > -1)
                {
                    string name = reader.ReadString();
                    int age = reader.ReadInt32();
                    // по считанным данным создаем объект Person и добавляем в список
                    people2.Add(new Person(name, age));
                }
            }
            // выводим содержимое списка people на консоль
            foreach (Person person in people2)
            {
                Console.WriteLine($"Name: {person.Name}  Age: {person.Age}");
            }

            Console.ReadKey();


        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
