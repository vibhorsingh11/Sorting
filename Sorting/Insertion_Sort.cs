using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Insertion_Sort
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 3, 1, 8, 7, 2, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        j--;
                    }
                    else
                    {
                        break;
                    }
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
