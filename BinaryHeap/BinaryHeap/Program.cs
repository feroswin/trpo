using System;

public class MinBinaryHeap
{
    private int[] heap; // Массив для хранения кучи
    private int size;   // Текущий размер кучи

    public MinBinaryHeap(int capacity)
    {
        heap = new int[capacity];
        size = 0;
    }

    // Метод для добавления элемента в кучу
    public void Insert(int value)
    {
        if (size == heap.Length)
        {
            Console.WriteLine("Куча переполнена.");
            return;
        }

        size++;
        int currentIndex = size - 1; // Индекс добавленного элемента
        heap[currentIndex] = value;

        // Поднимаем элемент вверх, чтобы восстановить свойство минимальной кучи
        while (currentIndex > 0 && heap[currentIndex] < heap[ParentIndex(currentIndex)])
        {
            Swap(currentIndex, ParentIndex(currentIndex));
            currentIndex = ParentIndex(currentIndex);
        }
    }

    // Метод для удаления корневого элемента
    public int ExtractMin()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Куча пуста.");
            return -1; // Возвращаем -1, чтобы обозначить ошибку
        }

        int root = heap[0]; // Корневой элемент - минимальный элемент
        heap[0] = heap[size - 1]; // Заменяем корневой элемент последним элементом в куче
        size--;

        Heapify(0); // Восстанавливаем свойство минимальной кучи, опуская новый корневой элемент

        return root;
    }

    // Метод для просмотра корневого элемента
    public int PeekMin()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Куча пуста.");
            return -1; // Возвращаем -1, чтобы обозначить ошибку
        }

        return heap[0];
    }

    // Проверка, пуста ли куча
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Метод для восстановления свойства минимальной кучи (просеивание вниз)
    private void Heapify(int index)
    {
        int smallest = index;
        int left = LeftChildIndex(index);
        int right = RightChildIndex(index);

        if (left < size && heap[left] < heap[smallest])
        {
            smallest = left;
        }

        if (right < size && heap[right] < heap[smallest])
        {
            smallest = right;
        }

        if (smallest != index)
        {
            Swap(index, smallest);
            Heapify(smallest);
        }
    }

    private int ParentIndex(int index)
    {
        return (index - 1) / 2;
    }

    private int LeftChildIndex(int index)
    {
        return 2 * index + 1;
    }

    private int RightChildIndex(int index)
    {
        return 2 * index + 2;
    }

    private void Swap(int i, int j)
    {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}

class Program
{
    static void Main()
    {
        MinBinaryHeap minHeap = new MinBinaryHeap(10);

        minHeap.Insert(4);
        minHeap.Insert(8);
        minHeap.Insert(2);
        minHeap.Insert(5);

        Console.WriteLine("Корневой элемент " + minHeap.PeekMin());

        Console.WriteLine("Минимальный элемент: " + minHeap.PeekMin()); // Выводим минимальный элемент (2)
        Console.WriteLine("Извлеченный минимальный элемент: " + minHeap.ExtractMin()); // Извлекаем и выводим минимальный элемент (2)
        Console.WriteLine("Новый минимальный элемент: " + minHeap.PeekMin()); // Выводим новый минимальный элемент (4)
        Console.ReadKey();
    }
}

