using System.Text;

namespace data_structures_and_algorithms.DS_Stack.StackUsingArray;

public class Stack<T>
{
	private T[] Objects {  get; set; }
	private int Size { get; set; }

	public Stack(int length)
	{
		Objects = new T[length];
		Size = 0;
	}

	public T? Peek() 
	{
		if (Objects == null || Size == 0)
		{
			return default(T);
		}

		return Objects[Size - 1];
	}

	public void Push(T value)
	{
		if (Size == Objects.Length)
		{
			throw new Exception("Stack Overflow");
		}

		Objects[Size++] = value;
	}

	public T Pop() 
	{
		if (Size == 0)
		{
			throw new Exception("Stack underflow");
		}

		var obj = Objects[--Size];
		Objects[Size] = default(T);

		return obj;
	}

	public override string ToString()
	{
		var result = new StringBuilder();
   
		for (int i = 0; i < Size; i++) 
		{
			result.Append($"{Objects[i].ToString()} ");
		}

		return result.ToString();
	}
}
