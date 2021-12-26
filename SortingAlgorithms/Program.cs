using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LogQuicksort(new int[] { 4, 9, 2, 1, 6, 3, 8 });
            LogQuicksort(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
            LogQuicksort(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });

            Console.WriteLine("");

            LogMergeSort(new int[] { 4, 9, 2, 1, 6, 3, 8 });
            LogMergeSort(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
            LogMergeSort(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });

            Console.WriteLine("");

            LogBubbleSort(new int[] { 4, 9, 2, 1, 6, 3, 8 });
            LogBubbleSort(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
            LogBubbleSort(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });

            Console.WriteLine("");

            LogInsertionSort(new int[] { 4, 9, 2, 1, 6, 3, 8 });
            LogInsertionSort(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
            LogInsertionSort(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });

            Console.WriteLine("");

            LogSelectionSort(new int[] { 4, 9, 2, 1, 6, 3, 8 });
            LogSelectionSort(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
            LogSelectionSort(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });

            Console.WriteLine("");

            LogBinarySearch(new int[] { 4, 9, 2, 1, 6, 3, 8 }, 4);
            LogBinarySearch(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 }, 68);
            LogBinarySearch(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 }, 5879);
        }

        private static void LogBinarySearch(int[] list, int number)
        {
            var numerFound = BinarySearch.Execute(list, number);

            string array = "";

            foreach (var item in list)
                array = $"{array} {item}";

            if (numerFound)
                Console.WriteLine($"Binary search: {number} was found in array [ {array} ]");
            else
                Console.WriteLine($"Binary search: {number} was NOT found in array [ {array} ]");
        }

        private static void LogSelectionSort(int[] list)
        {
            SelectionSort.Execute(list);

            string array = "";

            foreach (var item in list)
                array = $"{array} {item}";

            Console.WriteLine($"Selection Sort: {array}");
        }

        private static void LogInsertionSort(int[] list)
        {
            InsertionSort.Execute(list);

            string array = "";

            foreach (var item in list)
                array = $"{array} {item}";

            Console.WriteLine($"Insertion Sort: {array}");
        }

        private static void LogBubbleSort(int[] list)
        {
            BubbleSort.Execute(list);

            string array = "";

            foreach (var item in list)
                array = $"{array} {item}";

            Console.WriteLine($"Bubble Sort: {array}");
        }

        private static void LogMergeSort(int[] list)
        {
            MergeSort.Execute(list);

            string array = "";

            foreach (var item in list)
                array = $"{array} {item}";

            Console.WriteLine($"Merge Sort: {array}");
        }

        private static void LogQuicksort(int[] list)
        {
            Quicksort.QuicksortArray(list);

            string array = "";

            foreach (var item in list)
                array = $"{array} {item}";

            Console.WriteLine($"Quicksort: {array}");
        }
    }
}
