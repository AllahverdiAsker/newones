using System;

namespace _5_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Aslan", "Asif", "Agha", "Aygun", "Adem" };
            WantedNames(ref names);
            Console.WriteLine(WantedNames(ref names));

            static bool WantedNames(ref string[] names)
            {
                int count=0;
                    foreach (var items in names)
                    {
                        if (items.StartsWith('A'))
                        {
                        count++; 
                        }
                    }
                if (count == names.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            } 
        }
    }
}
