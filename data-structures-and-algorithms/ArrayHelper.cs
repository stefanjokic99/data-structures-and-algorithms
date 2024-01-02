namespace data_structures_and_algorithms;

public static class ArrayHelper
{

    public static int[]? TwoSum(int[] array, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < array.Length; i++)
        {
            var complement = target - array[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { i, map[complement] };
            }

            map.Add(array[i], i);
        }

        return null;
    }
    /* 
     * DOESN'T WORK 
     */
    public static int[] MaximumSubarray(int[] array)
    {
        var result = new List<int>();
        var sum = 0;

        foreach (var element in array)
        {
            var previousSum = sum;
            var newSum = sum + element;

            if (newSum >= previousSum)
            {
                sum = newSum;
                result.Add(element);
            }
        }

        return result.ToArray();
    }

    public static int[] MoveZeroes(int[] array)
    {
        for (int lastNonZeroFoundAt = 0, current = 0; current < array.Length; current++)
        {
            if (array[current] != 0)
            {
                var temp = array[current];
                array[current] = array[lastNonZeroFoundAt];
                array[lastNonZeroFoundAt++] = temp;
            }
        }

        return array;
    }

    public static bool ContainsDuplicate(int[] array)
    {
        var list = new List<int>();

        foreach (var element in array)
        {
            if (list.Contains(element))
            {
                return true;
            }
            list.Add(element);
        }

        return false;
    }

    public static int[] RotateArray(int[] array, int k)
    {
        var result = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[(i + k) % array.Length];
        }

        return result;

    }

    public static int? FindFirstRecurringNumber(int[] array)
    {
        var map = new Dictionary<int, bool>();
        
        foreach (var element in array)
        {
            if (map.ContainsKey(element) && map[element])
            {
                return element;
            }

            map.Add(element, true);
        }

        return null;
    }
}
