using System;
using Xunit;

namespace Merge_Sort
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 })]
        [InlineData(new int[] { 5, 12, 7, 5, 5, 7 })]
        [InlineData(new int[] { 2, 3, 5, 7, 13, 11 })]
        [InlineData(new int[] { 8, 4, 23, 42, 16, 15 })]
        public void CheckMergeSort(int[] array)
        {
            MergeSort.DoMergeSort(array);

            int min = array[0];
            bool isSorted = true;

            for (int i = 1; i < array.Length; i++)
            {
                if(min > array[i])
                {
                    isSorted = false;
                    break;
                }
            }

            Assert.True(isSorted);
        }
    }
}
