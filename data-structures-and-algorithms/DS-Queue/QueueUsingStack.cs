using System.Text;

namespace data_structures_and_algorithms.DS_Queue.QueueUsingStack;

public class Queue<T>
{
    private Stack<T> Stack { get; set; }
    private Stack<T> AuxiliaryStack { get; set; }

    public Queue()
    {
        Stack = new Stack<T>();
        AuxiliaryStack = new Stack<T>();    
    }

    public T Peek()
    {
        T value;

        FillAuxiliaryStackWithStack();
        value = AuxiliaryStack.Peek();
        FillStackWithAuxiliaryStack();

        return value;
    }

    public void Enqueue (T Value)
    {
        Stack.Push(Value);
    }

    public T Dequeue()
    {
        T value;

        FillAuxiliaryStackWithStack();
        value = AuxiliaryStack.Pop();
        FillStackWithAuxiliaryStack();

        return value;

    }

    public override string ToString()
    {
        if (Stack.Count == 0)
        {
            return string.Empty;
        }

        var result = new StringBuilder();

        FillAuxiliaryStackWithStack();
        foreach ( var item in AuxiliaryStack) 
        {
            result.Append($"{item} ");
        }

        FillStackWithAuxiliaryStack();

        return result.ToString();
        
    }

    private void FillAuxiliaryStackWithStack()
    {
        while (Stack.Count > 0) 
        { 
            AuxiliaryStack.Push (Stack.Pop());
        }
    }

    private void FillStackWithAuxiliaryStack()
    {
        while (AuxiliaryStack.Count > 0)
        {
            Stack.Push(AuxiliaryStack.Pop());
        }
    }
}
