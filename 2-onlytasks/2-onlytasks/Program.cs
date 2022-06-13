using System;

namespace _2_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 5, 7, 3, 7, 9, 3, 2, 1, 2, 2, 4, 5, 6 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] newnumbers = new int[0];
                if (numbers[i] % 2 == 0)
                {
                    
                        Array.Resize(ref newnumbers, newnumbers.Length + 1);
                        newnumbers[newnumbers.Length - 1] = numbers[i];
                        foreach(var item in newnumbers)
                        {
                        Console.WriteLine(item);
                        }

                }

            }

            
        }
    }
}
