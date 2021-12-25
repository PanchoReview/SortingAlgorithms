using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Quicksort
    {
        //1. Choose pivot
        //2. Partition
        //3. Recursively quicksort

        public static void QuicksortArray(int[] array)
        {
            int lowIndex = 0;
            int highIndex = array.Length - 1;

            QuicksortArray(array, lowIndex, highIndex);
        }

        public static void QuicksortArray(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex >= highIndex)
                return;

            //Choose pivot at random
            int pivotIndex = new Random().Next(highIndex - lowIndex) + lowIndex;
            int pivot = array[pivotIndex];
            Swap(array, pivotIndex, highIndex);

            int leftPointer = Partition(array, lowIndex, highIndex, pivot);

            QuicksortArray(array, lowIndex, leftPointer - 1);
            QuicksortArray(array, leftPointer + 1, highIndex);
        }

        private static int Partition(int[] array, int lowIndex, int highIndex, int pivot)
        {
            int leftPointer = lowIndex;
            int rightPointer = highIndex;

            while (leftPointer < rightPointer)
            {
                while (array[leftPointer] <= pivot && leftPointer < rightPointer)
                {
                    leftPointer++;
                }

                while (array[rightPointer] >= pivot && leftPointer < rightPointer)
                {
                    rightPointer--;
                }

                Swap(array, leftPointer, rightPointer);
            }

            Swap(array, leftPointer, highIndex);

            return leftPointer;
        }

        private static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
