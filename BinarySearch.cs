using System;
using static System.Console;

namespace Sorting
{
    class BinarySearch
    {
        public object Search(int[] arr, int target)
        {
            int lower = 0;
            int higher = arr.Length - 1;
            
            while (lower <= higher)
            {
                int mid = (lower + higher) / 2;    
                if (target == arr[mid]) return ++mid;
                if (target < arr[mid])
                {
                    higher = mid - 1;
                }
                else
                {
                    lower = mid + 1;
                }
            }
            return "None";
        }
    }
}