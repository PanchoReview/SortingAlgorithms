using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        //1. Divide array in half continuously until we get only individual items

        public static void Execute(int[] array)
        {
            int inputLength = array.Length; //Save input array length for further use

            if (inputLength < 2) //If array has zero or 1 elements in it, don't do anything
                return;

            int midIndex = inputLength / 2; //Calculate middle index which we'll use to divide the array in two
            int[] leftHalf = new int[midIndex]; //Left half array will have a length of midIndex
            int[] rightHalf = new int[inputLength - midIndex]; //Right half array will hav a length of inputLength minus midIndex

            //for each index in the array up until midIndex, we copy everything to the left half array
            for (int i = 0; i < midIndex; i++)
            {
                leftHalf[i] = array[i];
            }

            //for each index in the array up until the input length of the array, we copy everything to the right of the array
            for (int i = midIndex; i < inputLength; i++)
            {
                rightHalf[i - midIndex] = array[i];
            }

            //Recursively merge sort left half and right half
            Execute(leftHalf); 
            Execute(rightHalf);

            //Once halves have been sorted, merge them into the original array overriding each position of the array
            Merge(array, leftHalf, rightHalf);            
        }

        private static void Merge(int[] array, int[] leftHalf, int[] rightHalf)
        {
            int leftSize = leftHalf.Length; //Get length of left half of the array
            int rightSize = rightHalf.Length; //Get length of right half of the array

            int i = 0; //iterator for left half
            int j = 0; //iterator for right half
            int k = 0; //iterator for merged array

            //As long as we have items to iterate through in both arrays
            //We compare them
            while(i < leftSize && j < rightSize)
            {
                //If index of left half is less or equal than that of right half, we add it to the array
                //Else, we add the index item in the right half
                if (leftHalf[i] <= rightHalf[j])
                {
                    array[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    array[k] = rightHalf[j];
                    j++;
                }

                k++;
            }

            //Either the left and/or right half will be completely iterated through at this point
            //Now, iterate through the remnants of either half, and add them to the final array
            //As those items are already sorted within the array, they will be placed in order in the final array

            while(i < leftSize)
            {
                array[k] = leftHalf[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                array[k] = rightHalf[j];
                j++;
                k++;
            }            
        }

    }
}
