using System;
using System.IO;
using static System.Console;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = {1002,-100,0,6,1,54,22,-2,93,100,345,21,3,2,4,88,56,1001};
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
