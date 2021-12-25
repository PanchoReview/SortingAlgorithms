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


            LogMergeSort(new int[] { 4, 9, 2, 1, 6, 3, 8 });
            LogMergeSort(new int[] { 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
            LogMergeSort(new int[] { -854, 1583, -12, 987, 1, 2, 3, 3, 4, 5879, 1897585, 8, 8, 9, 10, -5, -4, -2, 7, 15, 1080, 208, 597, 475, 784, 39 });
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
