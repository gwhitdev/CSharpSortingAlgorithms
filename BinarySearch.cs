using System;
using static System.Console;

namespace Sorting
{
    class BinarySearch
    {
        public object Search(int[] arr, int target) // array must be sorted
        {
            int lower = 0; // set the lower bounds
            int higher = arr.Length - 1; // set the upper bounds
            
            while (lower <= higher) // stop after the two values collide -> we've looked at everything
            {
                int mid = (lower + higher) / 2; // find the mid point
                if (target == arr[mid]) return ++mid; // if the element at the indexed mid point == the target, return the midpoint in 'real terms'
                if (target < arr[mid])
                {
                    higher = mid - 1; // if target is less than the current selected element, decrement the midpoint value
                }
                else
                {
                    lower = mid + 1; // if target is more than the current selected element, increment the midpoint value
                }
            }
            return "None"; // if the target cannt be found, return the string "None"
        }
    }
}