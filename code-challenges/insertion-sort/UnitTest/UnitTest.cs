using System;
using Xunit;
using InsertionSort;

namespace UnitTest
{
    public class UnitTest
    {
        /// <summary>
        /// Tests whether function performs successful insertion sort
        /// </summary>
        /// <param name="array">Array of ints, unsorted</param>
        [Theory]
        [InlineData(new int[] { 8, 6, 4, 12 })]
        [InlineData(new int[] { 3, 1213, 3, 5, 624, 6, 4, 6, 3 })]
        [InlineData(new int[] { 3, 6, 2, 246, 624, 2, 5, 6, 4 })]
        [InlineData(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 20, 18, 12, 8, 5, -2 })]
        public void CheckSuccessfulInsertionSort(int[] array)
        {
            InsertionSort.InsertionSort.SortIntArray(array);

            Assert.True(InsertionSort.InsertionSort.CheckSortedIntArray(array));
        }
    }
}
