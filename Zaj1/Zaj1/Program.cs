using System;

namespace Zaj1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //komentarz kolego
        }

        public static int CalculateMax(int[] tab)
        {
            int maxVal = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > maxVal)
                {
                    maxVal = tab[i];
                }
            }
            return maxVal;
        }
        
        
        
    }
}