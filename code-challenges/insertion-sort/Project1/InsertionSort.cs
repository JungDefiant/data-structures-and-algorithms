using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public static class InsertionSort
    {
        /// <summary>
        /// Takes an array and performs insertion sort in place
        /// </summary>
        /// <param name="array">Array of ints, unsorted</param>
        public static void SortIntArray(int[] array)
        {
            try
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int j = i - 1;
                    int temp = array[i];

                    while(j >= 0 && temp < array[j])
                    {
                        array[j + 1] = array[j];
                        j = j - 1;
                    }

                    array[j + 1] = temp;
                }
            }
            catch(IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// Checks whether array is sorted
        /// </summary>
        /// <param name="array">Array of ints</param>
        /// <returns>Boolean verifying whether array is sorted</returns>
        public static bool CheckSortedIntArray(int[] array)
        {
            if(array.Length < 1) return true;

            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) return false;
            }

            return true;
        }
    }
}
