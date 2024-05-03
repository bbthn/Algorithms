using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class QuickShort
    {
     // Time Complexity Worst Case = O(n^2)
     // Time Complexity Avarage Case = O^n(Logn)


        int[] numbers = { 8, 5, 666, -123, 0, 10000, 2, 7 };
        void QuickSortLomouto(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSortLomouto(arr, low, pivotIndex - 1);
                QuickSortLomouto(arr, pivotIndex + 1, high);

            }
        }
        int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);

            return i + 1;
        }
        void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
