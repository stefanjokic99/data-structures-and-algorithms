namespace data_structures_and_algorithms.DS_HashTable;


public record Node<T>(string Key, T Value);
public class NodeList<T> : List<Node<T>> { };

public sealed class CustomHashTable<T>
{
    public int Length { get; private set; }
    public NodeList<T>[] Nodes { get; private set; }

    public CustomHashTable(int length)
    {
        Length = length;
        Nodes = new NodeList<T>[Length];
    }

    public T? Get(string key)
    {
        var index = Hash(key);
        
        if (Nodes[index] == null)
        {
            return default(T);
        }

        foreach (var node in Nodes[index]) 
        {
            if(node.Key.Equals(key)) 
            {
                return node.Value;
            }
        }

        return default(T);
    }

    public List<string> keys()
    {
        List<string> result = new List<string>();

        for (int i = 0; i < Nodes.Length; i++) 
        {
            if (Nodes[i] != null)
            {
                if (Nodes[i].Count > 1)
                {
                    for (int j = 0; j < Nodes[i].Count; j++)
                    {
                        result.Add(Nodes[i][j].Key);
                    }
                } 
                else
                {
                    result.Add(Nodes[i][0].Key);
                }
            }
        }

        return result;
    }

    public void Set(string key, T value)
    {
        var index = Hash(key);

        if (Nodes[index] == null) 
        {
            Nodes[index] = new NodeList<T>();
        }

        Nodes[index].Add(new Node<T>(key, value));
    }



    private int Hash(string key)
    {
        int hash = 0;
        
        for (int i = 0; i < key.Length; i++)
        {
            hash = (hash + (int)key[i] * i) % Length;
        }

        return hash;
    }
}

