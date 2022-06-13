using System;

namespace _5_onlytasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Aslan", "Bulut", "Agha", "Aygun", "Adem" };
            WantedNames(ref names);
            Console.WriteLine(WantedNames(ref names));

            static bool WantedNames(ref string[] names)
            {
                
                    foreach (var items in names)
                    {
                        if (items.StartsWith('A'))
                        {
                            return true;
                        }
                    }
                
                return false;
            } 
        }
    }
}
