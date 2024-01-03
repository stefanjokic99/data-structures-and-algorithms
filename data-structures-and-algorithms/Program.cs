#region DS-Array
/*
using data_structures_and_algorithms.DS_Array;

CustomArray array = new CustomArray();

array.Push("Hello");
array.Push("World");

Console.WriteLine(array);
*/

/*
using data_structures_and_algorithms.DS_Array;

Console.WriteLine(StringHelper.ReverseString("I am Stefan."));
*/

/*
using data_structures_and_algorithms.DS_Array;
using System.Text;

int[] array1 = { 1, 3, 5, 7 };
int[] array2 = { 2, 4, 6, 8 };

var resultArray = SortedArrayHelper.MergeSortedArrays(array1, array2);
var result = new StringBuilder("");

foreach (var item in resultArray)
{
    result.Append(item);
    result.Append(" ");
}

Console.WriteLine(result.ToString());


using data_structures_and_algorithms;
using System.Text;

int[] array = { 2, 7, 11, 15 };
int target = 9;

var resultArray = ArrayHelper.TwoSum(array, target);
var result = new StringBuilder("");

foreach (var item in resultArray)
{
    result.Append(item);
    result.Append(" ");
}

Console.WriteLine(result.ToString());


using data_structures_and_algorithms;
using System.Text;

int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

var resultArray = ArrayHelper.MaximumSubarray(array);
var result = new StringBuilder("");

foreach (var item in resultArray)
{
    result.Append(item);
    result.Append(" ");
}

Console.WriteLine(result.ToString());

using data_structures_and_algorithms;
using System.Text;

int[] array = { 0, 1, 0, 3, 12 };

var resultArray = ArrayHelper.MoveZeroes(array);
var result = new StringBuilder("");

foreach (var item in resultArray)
{
    result.Append(item);
    result.Append(" ");
}

Console.WriteLine(result.ToString());



using data_structures_and_algorithms;

int[] array = { 0, 1, 2, 3, 12 };

Console.WriteLine(ArrayHelper.ContainsDuplicate(array));


using data_structures_and_algorithms;
using System.Text;

int[] array = { 0, 1, 0, 3, 12 };

var resultArray = ArrayHelper.RotateArray(array, 1);
var result = new StringBuilder("");

foreach (var item in resultArray)
{
    result.Append(item);
    result.Append(" ");
}

Console.WriteLine(result.ToString());


using data_structures_and_algorithms.DS_Array;

Console.WriteLine(StringHelper.LongestWord("I      love     dogs."));
*/
#endregion


#region DS-HashTable
/*
using data_structures_and_algorithms.DS_HashTable;
using System.Text;

var myHashTable = new CustomHashTable<int>(2);
myHashTable.Set("grapes", 1000);
myHashTable.Set("apples", 54);
myHashTable.Set("strawberries", 13);

var keys = myHashTable.keys();
var result = new StringBuilder("");

foreach (var key in keys)
{
    result.Append(key);
    result.Append(" ");
}

Console.WriteLine(result.ToString());


using data_structures_and_algorithms;

int[] array = { 1, 5, 8, 15, 11, 18, 188, 7, 14, 4, 10 };
Console.Write(ArrayHelper.FindFirstRecurringNumber(array));
*/
#endregion


#region DS-LinkedList
/*
var linkedList = new data_structures_and_algorithms.LinkedList.LinkedList<int>(5);
linkedList.Append(1);
linkedList.Append(2);  
linkedList.Insert(0, 3);
linkedList.Remove(2);

Console.WriteLine(linkedList.ToString());
*/
var linkedList = new data_structures_and_algorithms.LinkedList.DoublyLinkedList.DoublyLinkedList<int>(5);
linkedList.Append(1);
linkedList.Append(2);
linkedList.Insert(0, 3);
linkedList.Remove(2);

Console.WriteLine(linkedList.ToString());

#endregion