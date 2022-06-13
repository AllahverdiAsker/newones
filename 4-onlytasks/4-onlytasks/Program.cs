using System;

namespace _4_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 9, };
            int[] numbers1 = { 3, 5, 7, 8, 4, 3, 2, 5, 6, 7 };
            SameNumbersInEachArray(ref numbers, ref numbers1);
            Console.WriteLine(SameNumbersInEachArray(ref numbers, ref numbers1));

            static bool SameNumbersInEachArray(ref int[] numbers, ref int[] numbers1)
            {

             for(int i = 0; i < numbers.Length; i++)
                {
                    for(int o=0;o<numbers1.Length;o++)
                    {
                        if (numbers[i] == numbers1[o])
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
        }
    }
}
