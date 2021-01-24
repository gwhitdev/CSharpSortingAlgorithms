using System;
using System.IO;
using static System.Console;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingArrayModel array = new SortingArrayModel();
            int[] arr = array.Numbers;
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

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(arr);
        }
    }
}
