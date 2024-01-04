using System.Text;

namespace data_structures_and_algorithms.DS_Queue.QueueUsingLinkedList;

public class Node<T>
{
    public T Value { get; private set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}

public class Queue<T>
{
    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }

    public Queue() 
    {
    }

    public T? Peek()
    {
        if (Head == null) 
        {
            throw new Exception("Queue is empty.");
        }

        return Head.Value;
    }


    public void Enqueue(T value)
    {
        var newNode = new Node<T>(value);

        if (Head == null) 
        {
            Head = newNode;
            Tail = newNode;

            return;
        }

        Tail.Next = newNode;
        Tail = newNode;
    }

    public T Dequeue ()
    {
        if (Head == null) 
        {
            throw new Exception("Queue is empty.");
        }

        var holdingPointer = Head;
        Head = Head.Next;

        return holdingPointer.Value;
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        var currentNode = Head;
        while (currentNode != null)
        {
            result.Append($"{currentNode.Value} ");
            currentNode = currentNode.Next;
        }

        return result.ToString();
    }
}
