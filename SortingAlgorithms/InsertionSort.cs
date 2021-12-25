using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        //Walk through an unstorted array from the first index onwards
        //Compare the value of current index to those before it, and swap each value depending on their values
        //Time complexity of this algorithm is (N*N) (N squared)
        public static void Execute(int[] array) 
        {
            int arrayLength = array.Length;
            if (arrayLength < 2)
                return;

            //We start walking through the array from left to right, starting with the second position at index 1
            //This is because element at index 0 is already sorted in itself, and there are no further elements to compare to it's left
            for (int i = 1; i < arrayLength; i++)
            {   
                int currentValue = array[i]; //We store the current value in a variable
                int j = i -1; //We set j as our backwards iterator, which we'll use to inspect elements to the left of our current value

                //while j is greater than zero AND the element at position j is greater than the current value
                //we swap the position of currentValue and that of j
                while(j >= 0 && array[j] > currentValue)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                //At the end of the loop, we set the position of the current value as j + 1
                //If there were no iterations in the previous while, the position of current value will remain the same
                array[j + 1] = currentValue;
            }
        }

    }
}
