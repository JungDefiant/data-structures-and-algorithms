using System;

namespace ArrayShift
{
    class Program
    {
        public static void Main(string[] args)
        {
        }

        public static int[] InsertShiftArray(int numToInsert, int[] array)
        {
            int[] shiftArray = new int[array.Length + 1];

            for(int i = 0, j = 0; i < shiftArray.Length; i++, j++)
            {
                if (i == Math.Ceiling(array.Length / 2m))
                {
                    j--;
                    shiftArray[i] = numToInsert;
                }
                else shiftArray[i] = array[j];
            }

            Console.WriteLine(string.Join(',', shiftArray));
            return shiftArray;
        }
    }
}
