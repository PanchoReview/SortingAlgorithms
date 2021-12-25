using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        //The idea behind BubbleSort is that, having an array of N numbers, you must sort it by comparing each adjacent element
        //So, if you're taking element N in the array, it must be compared to elment N+1
        //If element N+1 is less than N, then the position of both elements must be swapped
        //Continue to do so iteratively until no swaps have occurred, in which case you'll know the array has been sorted perfectly

        public static void Execute(int[] array)
        {
            int arrayLength = array.Length;

            //If array has less than two elements, there is nothing to sort, so we do nothing
            if (arrayLength < 2)
                return;

            //Variable to detect whether values in this array have been sorted
            bool swappingHappened = false;

            //For loop to walk through each element and compare it to the next
            for (int i = 0; i < arrayLength; i++)
            {
                //if i + 1 equals arrayLength, we're at the last element and have no further element to compare to, so we continue
                if (i + 1 == arrayLength)
                    continue;

                //If next element is less than current element, we swuap positions
                if (array[i + 1] < array[i] )
                {
                    Swap(array, i, i + 1);
                    swappingHappened = true;
                }                    
            }

            //We continue executing bubble sort until no swappings have been detected, which means the array is sorted
            if (swappingHappened)
                Execute(array);
        }

        private static void Swap(int[] array, int leftIndex, int rightIndex) {
            int temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;
        }
    }
}
