using System;

namespace InsertionSort
{
    class Insertion
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {13, 10, 11 ,18, 17, 12, 15, 14, 19, 16};

            void Insertion(int[] vet)
            {
                for (int i = 1; i < vet.Length ; i++)
                {
                    int actualNumber    = vet[i];
                    //get always previus position of the vector
                    int preNumber       = i - 1;
                    
                    while (preNumber >= 0 && actualNumber < vet[preNumber])
                    {
                        //number pre walk to next index
                        vet[preNumber + 1] = vet[preNumber];
                        // number of time to walk if the second condition is true
                        preNumber--;
                    }
                    //number less walk to previus index
                    vet[preNumber + 1] = actualNumber;
                }
                Console.WriteLine(String.Join(" ", vet));
            }            
            Insertion(array);
        }
    }
}