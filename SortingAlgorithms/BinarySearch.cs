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

            //If array has less than two items
            if (length <  2)
            {
                //if it has only one item, we compare it to our number to find to see whether it is contained in the array or not
                if (length == 1 && array[0] == numberToFind)
                    return true;

                //if it has no items, return false, as the number is not in the array
                return false;
            }

            //get the middle index of the array
            int middleIndex = length / 2;

            //sort the array
            Array.Sort(array);

            //if item at middle index equals the number to find, return true
            if (array[middleIndex] == numberToFind)
                return true;

            //else, setup a subarray to store numbers left or right of the middle index
            int[] subarray;

            if (array[middleIndex] > numberToFind)
                subarray = SetupLeftArray(array, numberToFind, length, middleIndex);
            else
                subarray = SetupRightArray(array, numberToFind, length, middleIndex);

            //run binary search again, this time with the subarray of numbers
            return Execute(subarray, numberToFind);
        }

        private static int[] SetupLeftArray(int[] array, int numberToFind, int length, int middleIndex)
        {
            var left = new int[middleIndex];

            for (int i = 0; i < middleIndex; i++)
            {
                left[i] = array[i];
            }

            return left;
        }

        private static int[] SetupRightArray(int[] array, int numberToFind, int length, int middleIndex)
        {
            var right = new int[length - middleIndex];

            for (int i = middleIndex; i < length; i++)
            {
                right[i - middleIndex] = array[i];
            }

            return right;
        }
    }
}
