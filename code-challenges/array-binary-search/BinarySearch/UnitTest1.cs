using System;
using Xunit;

namespace BinarySearch
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[5] { 1, 2, 3, 4, 5 }, 2)]
        [InlineData(new int[4] { 1, 2, 3, 4 }, 2)]
        [InlineData(new int[3] { 1, 2, 3 }, 2)]
        [InlineData(new int[2] { 1, 2 }, 2)]
        public void SearchForExistingNumber(int[] array, int key)
        {
            int searchResult = Program.BinarySearch(array, key);

            Assert.True(searchResult == key);
        }

        [Theory]
        [InlineData(new int[5] { 1, 2, 3, 4, 5 }, 9)]
        [InlineData(new int[4] { 1, 2, 3, 4 }, 9)]
        [InlineData(new int[3] { 1, 2, 3 }, 9)]
        [InlineData(new int[2] { 1, 2 }, 9)]
        public void SearchForNonExistingNumber(int[] array, int key)
        {
            int searchResult = Program.BinarySearch(array, key);

            Assert.True(searchResult == -1);
        }
    }
}
