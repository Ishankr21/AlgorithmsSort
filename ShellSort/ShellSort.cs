using System;

namespace ShellSort
{
    class Shell
    {
        void ShellSort(int[] arr, int size)
        {
            int gap = 1;
            while (gap < size)
            {
                gap = gap * 3 + 1;
            }

            while (gap > 1)
            {
                gap /= 3;
                for (int i = gap; i < size; i++)
                {
                    int value = arr[i];
                    int j     = i - gap;

                    while (j >= 0 && value < arr[j])
                    {
                        arr [j + gap] = arr[j];
                        j -= gap;
                    }
                    arr [j + gap] = value;
                }
            }       
            
        }
        
        static void Main(string[] args)
        {
            int[] array = new int[] {13, 10, 11 ,18, 17, 12, 15, 14, 19, 16};
            int size       = array.Length;
            
            Shell ob = new Shell();
            ob.ShellSort(array, size);
            
            Console.WriteLine(String.Join(" ", array));
        }
    }
}