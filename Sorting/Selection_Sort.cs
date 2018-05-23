using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Selection_Sort
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };


            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }

            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
            Console.ReadLine();
        }
    }
}
