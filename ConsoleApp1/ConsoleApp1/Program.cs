using System;

// Клас для представлення вузла дерева
class Node
{
    public int Key;
    public Node Left, Right;

    // Конструктор
    public Node(int item)
    {
        Key = item;
        Left = null;
        Right = null;
    }
}

// Клас Двійкового дерева пошуку
class BinarySearchTree
{
    private Node root;

    // Конструктор
    public BinarySearchTree()
    {
        root = null;
    }

    // Публічний метод для вставки елемента
    public void Insert(int key)
    {
        root = InsertRecursive(root, key);
    }

    // Рекурсивна функція вставки нового ключа
    private Node InsertRecursive(Node node, int key)
    {
        // Якщо дерево порожнє, повертаємо новий вузол
        if (node == null)
        {
            return new Node(key);
        }

        // Властивість дерева пошуку: менші йдуть ліворуч, більші — праворуч
        if (key < node.Key)
        {
            node.Left = InsertRecursive(node.Left, key);
        }
        else if (key > node.Key)
        {
            node.Right = InsertRecursive(node.Right, key);
        }

        return node;
    }

    // Публічний метод для друку всіх листів
    public void PrintLeaves()
    {
        if (root == null)
        {
            Console.WriteLine("Дерево порожнє.");
            return;
        }

        Console.Write("Ключі в листах дерева: ");
        PrintLeavesRecursive(root);
        Console.WriteLine();
    }

    // Рекурсивна функція для пошуку та друку листів
    private void PrintLeavesRecursive(Node node)
    {
        if (node == null)
        {
            return;
        }

        // Перевірка, чи є поточний вузол листом (не має нащадків)
        if (node.Left == null && node.Right == null)
        {
            Console.Write(node.Key + " ");
        }

        // Продовжуємо обхід для лівого та правого піддерева
        PrintLeavesRecursive(node.Left);
        PrintLeavesRecursive(node.Right);
    }
}

// Головний клас програми
class Program
{
    static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();

        // Вставляємо ключі у дерево
        // Структура дерева буде такою:
        //          50
        //        /    \
        //      30      70
        //     /  \    /  \
        //   20   40  60   80
        //  /
        // 10

        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(70);
        tree.Insert(60);
        tree.Insert(80);
        tree.Insert(10);

        // Друкуємо листи (вузли, що не мають нащадків)
        // Очікуваний результат: 10 40 60 80
        tree.PrintLeaves();
    }
}