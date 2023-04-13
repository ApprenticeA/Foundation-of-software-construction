using System;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList<T>
{
    private Node<T> head;

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    public void ForEach(Action<T> action)
    {
        Node<T> current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddFirst(1);
        list.AddFirst(2);
        list.AddFirst(3);
        list.AddFirst(4);

        Console.WriteLine("Printing elements using ForEach:");
        list.ForEach(item => Console.WriteLine(item));

        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        list.ForEach(item =>
        {
            sum += item;
            min = Math.Min(min, item);
            max = Math.Max(max, item);
        });

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
    }
}
