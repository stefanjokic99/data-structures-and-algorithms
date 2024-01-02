namespace data_structures_and_algorithms.DS_Array
{
    public static class SortedArrayHelper
    {
        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];

            var i = 0;
            var j = 0;
            var k = 0;

            while (i < array1.Length && j < array2.Length) 
            {
                if (array1[i] < array2[j])
                {
                    result[k++] = array1[i++];
                    continue;
                }
                result[k++] = array2[j++];
            }

            while (i < array1.Length)
            {
                result[k++] = array1[i++];
            }

            while (j < array2.Length)
            { 
                result[k++] = array2[j++]; 
            }

            return result;

        }
    }
}
