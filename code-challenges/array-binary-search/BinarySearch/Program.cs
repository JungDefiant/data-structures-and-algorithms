using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class Program
    {
        public static void Main(string[] args)
        {

        }

        public static int BinarySearch(int[] sortedArray, int key)
        {
            int middleInd = sortedArray.Length / 2;
            int middleKey = sortedArray[middleInd];

            while (key != middleKey 
                && middleInd != 0 
                && middleInd != sortedArray.Length - 1)
            {
                if (key < middleKey) middleInd = middleInd / 2;
                else middleInd = (middleInd + sortedArray.Length) / 2;

                middleKey = sortedArray[middleInd];
            }

            if (middleKey == key) return sortedArray[middleInd];
            else return -1;
        }
    }
}
