using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int[] arr = { 2, 3, 4, 5, 1 };
            int size = arr.Length;
            InversePermutation(arr, size);
        }
        static int[] InversePermutation(int[] arr, int size)
        {
            List<int> arrayItems = new List<int>();
            int a, b;
            for (a = 0; a < size; a++)
            {
                for (b = 0; b < size; b++)
                {
                    if (arr[b] == a + 1)
                    {
                        arrayItems.Add(b + 1);
                        break;
                    }
                }
            }
            return arrayItems.ToArray();
        }

        
    }
}