using System;

namespace _6_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { };
            int n = 4;
            array = Resize(array, n);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
            
        }

        static int[] Resize(int[] array,int n)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = n;
            return array;
        }

    }
}
