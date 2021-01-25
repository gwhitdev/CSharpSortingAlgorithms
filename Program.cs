using System;
using System.IO;
using static System.Console;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 21;
            SortingArrayModel array = new SortingArrayModel();
            int[] arr = array.Numbers;

            BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Sort(arr);
            BinarySearch binarySearch = new BinarySearch();
            var result = binarySearch.Search(bubbleSort.Sort(arr), target);
            WriteLine(result);

            /*
            int length = arr.Length;
            
            WriteLine("QuickSort");
            foreach(var e in arr)
            {
                Write(e + " ");
            }

            QuickSort quickSort = new QuickSort();
            quickSort.Sort(arr, 0, length - 1);

            WriteLine("");
            Write("Sorted: ");
            foreach(var e in arr)
            {
                Write(e + " ");
            }
            ReadKey();
            */

            
        }
    }
}
