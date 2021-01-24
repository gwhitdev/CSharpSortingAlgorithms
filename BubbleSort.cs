using static System.Console;
using System.Threading;

namespace Sorting
{
    class BubbleSort
    {
        public int[] Sort(int[] arr)
        {
            Write("Intial array: ");
            foreach(var e in arr)
            {
                Write(e + " ");
            }
            WriteLine("");
            while (true)
            {
                bool swapped = false;
                int moving = 0;
                for(var i = 0; i < arr.Length -1; i++)
                {
                    if (arr[i] > arr[i+1]) 
                    {
                        
                        int element = arr[i];
                        moving = element;
                        arr[i] = arr[i+1];
                        arr[i+1] = element;
                        swapped = true;
                    }
                    
                }
               // WriteLine("Moving number [" + moving + "]");
                foreach(var e in arr)
                {
                    Write(e + " ");
                }
                WriteLine("");
                //Thread.Sleep(2000);

                if(!swapped) return arr;
            }
            
        }
    }
}