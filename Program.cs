using System;
using System.IO;
using static System.Console;
using Algorithms.Sorting;
using Algorithms.Searching;
using Algorithms.Models;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingArrayModel array = new SortingArrayModel();
            int[] arr = array.Numbers;
            int target = 21;

            BubbleSort bubbleSort = new BubbleSort();
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
