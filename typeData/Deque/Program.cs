using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дек (Deque, или двусторонняя очередь) - это структура данных, которая поддерживает операции добавления и удаления элементов
// как в начало, так и в конец коллекции.
namespace Deque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> deque = new LinkedList<int>();

            // Добавляем элементы в начало и конец дека.
            deque.AddFirst(1);
            deque.AddLast(2);
            deque.AddLast(3);

            // Извлекаем и выводим элементы с начала и с конца дека.
            while (deque.Count > 0)
            {
                int firstItem = deque.First.Value;
                int lastItem = deque.Last.Value;

                deque.RemoveFirst();
                deque.RemoveLast();

                Console.WriteLine($"First: {firstItem}, Last: {lastItem}");
            }
        }
    }
}
