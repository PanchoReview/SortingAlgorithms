using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BinarySearch
    {
        public static bool Execute(int[] array, int numberToFind)
        {
            int length = array.Length;

            if (length <  2)
            {
                if (length == 1 && array[0] == numberToFind)
                    return true;

                return false;
            }

            int middleIndex = length / 2;

            Array.Sort(array);

            if (array[middleIndex] == numberToFind)
                return true;
            else if (array[middleIndex] > numberToFind)
                return SearchInLeftArray(array, numberToFind, length, middleIndex);
            else
                return SearchInRightArray(array, numberToFind, length, middleIndex);
        }

        private static bool SearchInLeftArray(int[] array, int numberToFind, int length, int middleIndex)
        {
            var left = new int[middleIndex];

            for (int i = 0; i < middleIndex; i++)
            {
                left[i] = array[i];
            }

            return Execute(left, numberToFind);
        }

        private static bool SearchInRightArray(int[] array, int numberToFind, int length, int middleIndex)
        {
            var right = new int[length - middleIndex];

            for (int i = middleIndex; i < length; i++)
            {
                right[i - middleIndex] = array[i];
            }

            return Execute(right, numberToFind);
        }
    }
}
