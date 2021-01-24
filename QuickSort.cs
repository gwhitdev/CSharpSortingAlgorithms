using System;
using static System.Console;

namespace Sorting
{
    class QuickSort
    {
        public int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int lowIndex = (low - 1);
            for (int j = low; j < high; j++)
            {
                WriteLine("arr[j] " + arr[j]);
                WriteLine("pivot " + pivot);
                if (arr[j] <= pivot)
                {
                    lowIndex++;

                    int temp = arr[lowIndex];
                    
                    arr[lowIndex] = arr[j];
                    WriteLine("arr[j] " + arr[j]);
                    arr[j] = temp;
                    WriteLine("arr[j] = " + arr[j] + " temp = " + temp);
                }
            }
            int temp1 = arr[lowIndex + 1];
            arr[lowIndex + 1] = arr[high];
            

            arr[high] = temp1;

            return lowIndex + 1;
        }
        public void Sort(int[] arr, int low, int high) 
        {
            if(low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                Sort(arr, low, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, high);
            }
        }
    }
}