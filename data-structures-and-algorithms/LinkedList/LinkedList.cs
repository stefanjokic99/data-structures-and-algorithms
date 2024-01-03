using System.Text;

namespace data_structures_and_algorithms.LinkedList;

public class Node<T>
{
    public T Value { get; private set;}
    public Node<T> Next { get; set;}

    public Node(T value)
    {
        Value = value;
    }
}

public class LinkedList<T>
{
    public Node<T> Head { get; private set; }
    public Node<T> Tail { get; private set; }
    public int Length { get; private set; }

    public LinkedList(T value)
    {
        Head = new Node<T>(value);
        Tail = Head;
        Length = 1;
    }

    public void Append(T value)
    {
        Tail.Next= new Node<T>(value);
        Tail = Tail.Next;
    
        Length++;
    }

    public void Prepend(T value)
    {
        var newNode = new Node<T>(value);
        
        newNode.Next = Head;    
        Head = newNode;

        Length++;
    }

    public void Insert(int index, T value)
    {
        Node<T> newNode;
        Node<T> leader;
        Node<T> holdingPointer;

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
        holdingPointer = leader.Next;

        leader.Next = newNode;
        newNode.Next = holdingPointer;
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
        Length--;
    }

    public void Reverse()
    {
        Node<T> first = Head;
        Node<T> second = first.Next;

        Tail = Head;
        for (int i = 0; i < Length - 1; i++) 
        {
            var temp = second.Next;
            second.Next = first;
            first = second;
            second = temp;
        }

        Head.Next = null;
        Head = first;
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

        while(counter != index) 
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
