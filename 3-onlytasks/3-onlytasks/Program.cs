using System;

namespace _3_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 22, 23, 24 };
            int n = 20;
            int min = 0;
            int max = numbers.Length - 1;
            int index = -1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (n == numbers[mid])
                {
                    index = mid;
                    break;
                }
                else if (n > numbers[mid])
                {
                    min = mid + 1;
                }
                else 
                {
                    max = mid - 1;
                }
            }
            if(index == -1)
            {
                Console.WriteLine("Wanted Number Not Found");

            }
            else
            {
                Console.WriteLine(n + "is wanted number" + "index of it is" + index);
            }
        }
    }
}
