using System;
using Xunit;

namespace ArrayShift
{
    public class ArrayShiftTesting
    {
        [Theory]
        [InlineData(5, new int[4] { 3, 2, 4, 7 })]
        [InlineData(5, new int[3] { 3, 2, 4 })]
        [InlineData(5, new int[2] { 3, 2 })]
        public void CheckTrueInputs(int num, int[] array)
        {
            int[] arrayToTest = Program.InsertShiftArray(num, array);
            int middleInd = (int)Math.Ceiling(arrayToTest.Length / 2m);

            Assert.True(arrayToTest[middleInd] == num);
        }

        [Fact]
        public void CheckNullInput()
        {
            int[] arrayToTest = Program.InsertShiftArray(1, new int[0] { });

            Assert.False(arrayToTest[0] == 1);
        }
    }
}
