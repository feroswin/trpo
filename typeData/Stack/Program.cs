using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Стек (Stack) - это структура данных, работающая по принципу "последним пришел - первым вышел" (LIFO).
namespace Stack
{

    class Stack<T>
    {
        private T[] items;
        private int top; // Индекс вершины стека

        public Stack(int capacity) {
            items = new T[capacity];
            top = -1; // Инициализируем вершину как -1 (стек не имеет элементов)
        }

        public void Push (T item)
        {
            if (top == items.Length - 1)
            {
                Console.WriteLine("Стек переполнен");
            }
            else
            {
                items[++top] = item; // Увеличиваем top и добавляем элемент на вершину стека
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст!");
                return default(T);
            }
            else
            {
                T item = items[top--]; // Удаляем элемент с вершины стека и уменьшаем top
                return item;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Стек пуст!");
                return default(T);
            }
            else
            {
                return items[top]; // Возвращаем элемент с вершины стека без удаления
            }
        }

        public bool IsEmpty ()
        {
            return top == -1;
        }

        public int Count()
        {
            return top + 1; // Кол-во элемнтов в стеке
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(5);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Вершина стека: " + stack.Peek()); // Должно вывести "Вершина стека: 3"
            Console.WriteLine("Количество элементов в стеке: " + stack.Count()); // Должно вывести "Количество элементов в стеке: 3"

            Console.WriteLine("Извлекаем элементы из стека:");
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("Вершина стека: " + stack.Peek());
            Console.WriteLine("Количество элементов в стеке: " + stack.Count());

            Console.ReadKey();
        }
    }
}
