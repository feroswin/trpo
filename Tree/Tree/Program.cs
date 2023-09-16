using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
ДАННЫЕ ДЛЯ ТЕСТА

Введите количество узлов в дереве: 5
Введите значение для узла 1: 1
Введите индекс левого ребенка для узла 1 (-1, если нет): 2
Введите индекс правого ребенка для узла 1 (-1, если нет): 3
Введите значение для узла 2: 2
Введите индекс левого ребенка для узла 2 (-1, если нет): 4
Введите индекс правого ребенка для узла 2 (-1, если нет): 5
Введите значение для узла 3: 3
Введите индекс левого ребенка для узла 3 (-1, если нет): -1
Введите индекс правого ребенка для узла 3 (-1, если нет): -1
Введите значение для узла 4: 4
Введите индекс левого ребенка для узла 4 (-1, если нет): -1
Введите индекс правого ребенка для узла 4 (-1, если нет): -1
Введите значение для узла 5: 5
Введите индекс левого ребенка для узла 5 (-1, если нет): -1
Введите индекс правого ребенка для узла 5 (-1, если нет): -1

*/


namespace Tree
{
    internal class Program
    {

        // Структура для представления узла дерева
        class TreeNode
        {
            public int Data;
            public int LeftChildIndex;
            public int RightChildIndex;
        }

        // Прямой обход (pre-order traversal)
        static void PreOrderTraversal(TreeNode[] tree, int currentIndex)
        {
            if (currentIndex == -1) return;

            Console.Write(tree[currentIndex].Data + " ");
            PreOrderTraversal(tree, tree[currentIndex].LeftChildIndex);
            PreOrderTraversal(tree, tree[currentIndex].RightChildIndex);
        }

        // Обратный обход (post-order traversal)
        static void PostOrderTraversal(TreeNode[] tree, int currentIndex)
        {
            if (currentIndex == -1) return;

            PostOrderTraversal(tree, tree[currentIndex].LeftChildIndex);
            PostOrderTraversal(tree, tree[currentIndex].RightChildIndex);
            Console.Write(tree[currentIndex].Data + " ");
        }

        // Симметричный обход (in-order traversal)
        static void InOrderTraversal(TreeNode[] tree, int currentIndex)
        {
            if (currentIndex == -1) return;

            InOrderTraversal(tree, tree[currentIndex].LeftChildIndex);
            Console.Write(tree[currentIndex].Data + " ");
            InOrderTraversal(tree, tree[currentIndex].RightChildIndex);
        }

        // Визуализация бинарного дерева
        static void VisualizeTree(TreeNode[] tree, int currentIndex, int level)
        {
            if (currentIndex == -1) return;

            VisualizeTree(tree, tree[currentIndex].RightChildIndex, level + 1);
            Console.WriteLine(new string(' ', level * 4) + tree[currentIndex].Data);
            VisualizeTree(tree, tree[currentIndex].LeftChildIndex, level + 1);
        }


        static void Main(string[] args)
        {

            // Запрос числа узлов в дереве и создание массива узлов
            Console.Write("Введите количество узлов в дереве: ");
            int numNodes = int.Parse(Console.ReadLine());

            TreeNode[] tree = new TreeNode[numNodes];

            // Заполнение значений узлов и индексов их детей
            for (int i = 0; i < numNodes; i++)
            {
                Console.Write($"Введите значение для узла {i + 1}: ");
                tree[i] = new TreeNode { Data = int.Parse(Console.ReadLine()) };

                Console.Write($"Введите индекс левого ребенка для узла {i + 1} (-1, если нет): ");
                tree[i].LeftChildIndex = int.Parse(Console.ReadLine());

                Console.Write($"Введите индекс правого ребенка для узла {i + 1} (-1, если нет): ");
                tree[i].RightChildIndex = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Прямой обход:");
            PreOrderTraversal(tree, 0);

            Console.WriteLine("\nОбратный обход:");
            PostOrderTraversal(tree, 0);

            Console.WriteLine("\nСимметричный обход:");
            InOrderTraversal(tree, 0);

            Console.ReadKey();
        }
    }
}
