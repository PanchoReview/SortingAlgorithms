using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class TortoiseAndHare
    {
        public static int Execute(int[] array)
        {
            int tortoise = array[0]; //Declare tortoise as first element of the array
            int hare = array[0]; //Declare hare as first element of the array

            while(true)
            {
                tortoise = array[tortoise];
                hare = array[array[hare]];

                if (tortoise == hare) //Break out of the array once the values of tortoise and hare are the same
                    break;
            }

            int ptr1 = array[0]; //Set first pointer to the first element of the array
            int ptr2 = tortoise; //Set second pointer to the value of tortoise

            //Move pointers through the array until they meet again.
            //The point where they meet, is where the cycle begins
            while(ptr1 != ptr2)
            {
                ptr1 = array[ptr1];
                ptr2 = array[ptr2];
            }

            return ptr1;
        }
    }
}
