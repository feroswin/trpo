using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Очередь (Queue) представляет собой структуру данных, которая работает по принципу FIFO
// Очередь полезна, когда важен порядок элементов, и необходимо обработать элементы в порядке их добавления
namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while( queue.Count > 0)
            {
                int item = queue.Dequeue();
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
