using System;

namespace _1_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Hasan", "Abdullah", "Abdurrahman", "Fatih", "Ihsan", "Abdulaziz" };
            int counter = 0;
            
           for(int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        
        }

        

    }
}
