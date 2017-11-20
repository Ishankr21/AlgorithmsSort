using System;

namespace MergeSort
{
    class Merge
    {
        // Merges two subarrays of arr[].
        // First subarray is arr[left..middle]
        // Second subarray is arr[middle+1..right]
        void MergeS(int[] arr, int left, int middle, int right)
        {
            // Find sizes of two subarrays to be merged
            int lenghtFirtArr   = middle - left + 1;
            int lenghtSecondArr = right  - middle;
            
            /* Create temp arrays */
            int[] tempArrLeft  = new int [lenghtFirtArr];
            int[] tempArrRight = new int [lenghtSecondArr];
            
            /*Copy data to temp arrays*/
            int i;
            for (i = 0; i<lenghtFirtArr; ++i)
                tempArrLeft[i] = arr[left + i];

            int j;
            for (j = 0; j<lenghtSecondArr; ++j)
                tempArrRight[j] = arr[middle + 1 + j];
            
            /* Merge the temp arrays */
            // Initial indexes of first and second subarrays
            i = 0; j = 0;
 
            // Initial index of merged subarry array
            int k = left;
            while (i < lenghtFirtArr && j < lenghtSecondArr)
            {
                if (tempArrLeft[i] <= tempArrRight[j])
                {
                    arr[k] = tempArrLeft[i];
                    i++;
                }
                else
                {
                    arr[k] = tempArrRight[j];
                    j++;
                }
                k++;
            }
            // Copy the remaining elements of tempL[], if there are any 
            while (i < lenghtFirtArr)
            { 
                arr[k] = tempArrLeft[i];
                i++;
                k++;
            }
 
            /* Copy the remaining elements of tempR[], if there are any */
            while (j < lenghtSecondArr)
            {
                arr[k] = tempArrRight[j];
                j++;
                k++;
            }
        }
        
        // Main function that sorts arr[left..right] using
        // merge()
        void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int middle = (left+right)/2;
 
                // Sort first and second halves
                Sort(arr, left, middle);
                Sort(arr , middle+1, right);
 
                // Merge the sorted halves
                MergeS(arr, left, middle, right);
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {13, 10, 11 ,18, 17, 12, 15, 14, 19, 16};
            
            Console.WriteLine("Given Array");
            Console.WriteLine(String.Join(" ", array));
 
            Merge ob = new Merge();
            ob.Sort(array, 0, array.Length - 1);
 
            Console.WriteLine("\nSorted array");
            Console.WriteLine(String.Join(" ", array));
        }
    }
}