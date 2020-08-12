using System;
using System.Collections.Generic;
using System.Text;

namespace Merge_Sort
{
    public class MergeSort
    {
        /// <summary>
        /// 
        /// Attribution: https://docs.microsoft.com/en-us/dotnet/api/system.array.copy?view=netcore-3.1
        /// </summary>
        /// <param name="array"></param>
        public static void DoMergeSort(int[] array)
        {
            int n = array.Length;

            if(n > 1)
            {
                int mid = n / 2;

                int[] left = new int[mid];
                Array.Copy(array, 0, left, 0, mid);

                int[] right = new int[mid];
                Array.Copy(array, mid, right, 0, mid);

                DoMergeSort(left);

                DoMergeSort(right);

                Merge(left, right, array);
            }
        }

        public static void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0, j = 0, k = 0;

            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }

                k++;
            }

            if(i == left.Length)
            {
                while (k < array.Length && j < right.Length)
                {
                    array[k] = right[j];
                    k++;
                    j++;
                }
            }
            else
            {
                while (k < array.Length && i < left.Length)
                {
                    array[k] = left[i];
                    k++;
                    i++;
                }
            }
        }
    }
}
