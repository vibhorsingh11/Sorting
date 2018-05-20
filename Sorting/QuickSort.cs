using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort
    {
        public static void Main(string[] agrs)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), tempArr => Convert.ToInt32(tempArr));
            int p = 0;
            int r = arr.Length - 1;
            Quicksort(arr, p, r);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
        static void Quicksort(int[] arr, int min, int max)
        {
            int p = min;
            int r = max;
            int pivot = arr[r];
            while (p < r)
            {
                while (arr[p] < pivot) { p++; }
                while (arr[r] > pivot) { r--; }
                if (p <= r)
                {
                    int t = arr[p];
                    arr[p] = arr[r];
                    arr[r] = t;
                    p++;
                    r--;
                }
            }
            if (min < r)
            {
                Quicksort(arr, min, r);
            }
            if (max > p)
            {
                Quicksort(arr, p, max);
            }
        }
    }
}
