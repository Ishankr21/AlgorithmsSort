using System;

namespace QuickSort
{
    class Quick
    {
        /* This function takes last element as pivot,
           places the pivot element at its correct
           position in sorted array, and places all
           smaller (smaller than pivot) to left of
           pivot and all greater elements to right
           of pivot 
        */
        int Partition(int[] vet, int low, int high )
        {
            int pivot = vet[high];
            int i     = (low - 1); // index of smaller element
            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or
                // equal to pivot
                if (vet[j] <= pivot)
                {
                    i++; 
                    // swap arr[i] and arr[j]
                    int temp = vet[i];
                    vet[i]   = vet[j];
                    vet[j]   = temp;
                }
                //Console.WriteLine(String.Join(",", vet));
            }
            
            // swap arr[i+1] and arr[high] (or pivot)
            int aux   = vet[i+1];
            vet[i+1]  = vet[high];
            vet[high] = aux;
 
            return i+1;
        }
        
        /* The main function that implements QuickSort()
          vet[] --> Array to be sorted,
          low   --> Starting index,
          high  --> Ending index 
        */
        void Sort(int[] vet, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, vet[pi] is now at right place */
                int pi = Partition(vet, low, high);
 
                // Recursively sort elements before
                // partition and after partition
                Sort(vet, low, pi-1);
                Sort(vet, pi+1, high);
            }
        }
        
        static void Main(string[] args)
        {
            int[] array = new int[] {13, 10, 11 ,18, 17, 12, 15, 14, 19, 16};
            int h       = array.Length;
            
            Quick ob = new Quick();
            ob.Sort(array, 0, h-1);
            
            Console.WriteLine(String.Join(",", array));
        }
    }
}