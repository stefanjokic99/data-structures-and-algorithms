using System.Text;

namespace data_structures_and_algorithms.LinkedList.DoublyLinkedList;

public class Node<T>
{
    public T Value { get; private set; }
    public Node<T> Next { get; set; }
    public Node<T> Previous { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}

public class DoublyLinkedList<T>
{
    public Node<T> Head { get; private set; }
    public Node<T> Tail { get; private set; }
    public int Length { get; private set; }

    public DoublyLinkedList(T value)
    {
        Head = new Node<T>(value);
        Tail = Head;
        Length = 1;
    }

    public void Append(T value)
    {
        Node<T> newNode = new Node<T>(value);

        newNode.Previous = Tail;
        Tail.Next = newNode;
        Tail = newNode;

        Length++;
    }


    public void Prepend(T value)
    {
        Node<T> newNode = new Node<T>(value);

        newNode.Next = Head;
        Head.Previous = newNode;
        Head = newNode;

        Length++;
    }

    public void Insert(int index, T value)
    {
        Node<T> newNode;
        Node<T> leader;
        Node<T> follower;

        index = WrapIndex(index);

        if (index == 0)
        {
            Prepend(value);
            return;
        }
        if (index == Length - 1)
        {
            Append(value);
            return;
        }

        newNode = new Node<T>(value);  
        leader = TraverseToIndex(index - 1);
        follower = leader.Next;

        leader.Next = newNode;
        newNode.Previous = leader;
        newNode.Next = follower;
        follower.Previous= newNode;

        Length++;
    }

    public void Remove(int index) 
    {
        Node<T> leader;
        Node<T> nodeToRemove;

        index = WrapIndex(index);

        if (index == 0)
        {
            Head = Head.Next;
            return;
        }

        leader = TraverseToIndex(index - 1);
        nodeToRemove = leader.Next;
        leader.Next = nodeToRemove.Next;
        nodeToRemove.Next.Previous = leader;
        
        Length--;
    }

    public override string ToString()
    {
        if (Head == null)
        {
            return String.Empty;
        }

        var result = new StringBuilder();

        var current = Head;
        while (current != null)
        {
            result.Append($"--->{current.Value.ToString()}");
            current = current.Next;
        }

        return result.ToString();
    }

    private Node<T> TraverseToIndex(int index)
    {
        Node<T> currentNode = Head;

        int counter = 0;
        index = WrapIndex(index);

        while (counter != index)
        {
            currentNode = currentNode.Next;
            counter++;
        }

        return currentNode;

    }

    private int WrapIndex(int index)
    {
        return Math.Max(Math.Min(index, Length - 1), 0);
    }
}
