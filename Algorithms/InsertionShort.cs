using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionShort
    {
        //Time complexity O(n^2)  Worst Case

        int[] numbers = { 8, 5, 2, 7, 666, 15, 55, -4, 9, 1, 0, 6, 3, 4, -1, 11 };

        int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int key = array[i];
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;

                }
                array[j + 1] = key;
            }

            return array;
        }
    }
}
