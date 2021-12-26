using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static void Execute(int[] array)
        {
            int length = array.Length;

            if (length < 2)
                return;

            //Walk through each item in the array, except the very last one
            for (int currentIndex = 0; currentIndex < length - 1; currentIndex++)
            {
                //Set item as the current minimum index
                int currentMinimumIndex = currentIndex;

                //Walk through each item in the array AFTER the current value
                for (int currentlyEvaluatedIndex = currentIndex + 1; currentlyEvaluatedIndex < length; currentlyEvaluatedIndex++)
                {
                    //If the value of the current evaluated item is less than the current minimum value, set it as current minimum
                    if (array[currentlyEvaluatedIndex] < array[currentMinimumIndex])
                        currentMinimumIndex = currentlyEvaluatedIndex;
                }

                //if current minimum index is different than the current index, swap values
                if (currentMinimumIndex != currentIndex)
                    Swap(array, currentIndex, currentMinimumIndex);
            }
        }

        private static void Swap(int[] array, int currentIndex, int currentMinimumIndex)
        {
            int temp = array[currentIndex];
            array[currentIndex] = array[currentMinimumIndex];
            array[currentMinimumIndex] = temp;
        }
    }
}
