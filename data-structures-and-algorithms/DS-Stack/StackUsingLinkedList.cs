using System.Text;

namespace data_structures_and_algorithms.DS_Stack.StackUsingLinkedList;

public class Node<T>
{
    public T Value { get; private set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}

public class Stack<T>
{
    private Node<T> Head { get; set; }

    public Stack()
    {
        Head = null;
    }

    public T Peek()
    {
        if (Head == null)
        {
            throw new Exception("Stack doesn't have elements");    
        }

        return Head.Value;
    }

    public void Push(T value)
    {
        var newNode = new Node<T>(value);

        newNode.Next = Head;
        Head = newNode;
    }

    public T Pop() 
    {
        if (Head == null)
        {
            throw new Exception("Stack doesn't have elements");
        }

        var element = Head.Value;
        Head = Head.Next;

        return element;
    }


    public override string ToString()
    {
        var result = new StringBuilder();
        
        var currentNode = Head;
        while(currentNode != null) 
        {
            result.Append($"{currentNode.Value} ");
            currentNode = currentNode.Next;
        }

        return result.ToString();
    }
}
