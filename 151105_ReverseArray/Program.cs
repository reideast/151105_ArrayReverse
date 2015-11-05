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
        
            int[] arr = new int[10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //write your logic here
            for (int i = 0, j = 9; i < 5; i++, j--) //loop through half the array
            {
                arr[i] ^= arr[j];
                arr[j] ^= arr[i];
                arr[i] ^= arr[j];
            }
            //end 

            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
