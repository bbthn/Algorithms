using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BubbleShort
    {
        //Bubble Sort
        //Time Complexity = O(n^2) -- 2 adet döngü
        //Space Complexity = O(1)  -- Heap alan açılmamış.

        int[] numbers = { 8, 5, 2, 7, 666, 15, 55, -4, 9, 1, 0, 6, 3, 4, -1, 11 };
        int[] BubleSortInt(int[] array)
        {

            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
            }
            return array;
        }
    }
}
