using System;

namespace SelectionSort
{
    class Selection 
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {13, 10, 11 ,18, 17, 12, 15, 14, 19, 16};

            void Selection(int[] vet)
            {
                for (int i = 0; i <= vet.Length - 1; i++)
                {
                    int posMin = i;

                    for (int j = i + 1; j < vet.Length; j++)
                    {
                        if (vet[j] < vet[posMin])
                        {
                            //get index position minium number
                            posMin = j;
                        }
                    }
                    
                    int x       = vet[posMin];
                    vet[posMin] = vet[i];
                    vet[i]      = x;
                    
                    Console.WriteLine(String.Join(" ", vet));
                }
            }
            
            Selection(array);
        }
    }
}