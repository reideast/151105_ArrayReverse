using System;

namespace _151105_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Enter the array elements[" + i + "]:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            const int SIZE = 10;
            int[] arr = new int[SIZE]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //write your logic here
            for (int i = 0, j = SIZE - 1; i < SIZE / 2; i++, j--) //loop through half the array
            {
                arr[i] ^= arr[j]; //XOR swap (note: don't do this in an actual project. see: https://en.wikipedia.org/wiki/XOR_swap_algorithm#Reasons_for_avoidance_in_practice )
                arr[j] ^= arr[i];
                arr[i] ^= arr[j];
            }
            //end 

            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
