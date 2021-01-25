using System;
using static System.Console;

namespace Sorting
{
    class BinarySearch
    {
        public object Search(int[] arr, int target) // array must be sorted
        {
            int lowerBounds = 0; 
            int higherBounds = arr.Length - 1; 
            
            while (lowerBounds <= higherBounds) // stop after the two values collide -> we've looked at everything
            {
                int midpoint = (lowerBounds + higherBounds) / 2;
                if (target == arr[midpoint]) return ++midpoint; // if the element at the indexed mid point == the target, return the midpoint in 'real terms'
                if (target < arr[midpoint]) // if target is less than the current selected element, decrement the midpoint value
                {
                    higherBounds = midpoint - 1; 
                }
                else // if target is more than the current selected element, increment the midpoint value
                {
                    lowerBounds = midpoint + 1; 
                }
            }
            return "None"; // target not found in the array?
        }
    }
}