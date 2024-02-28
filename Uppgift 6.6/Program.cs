using System;

namespace Uppgift_6._6
{
    class Program
    {
        static string StoraOchSmåBokstäver(string sträng)
        {
            string[] deladSträng = sträng.Split(" ");

            for (int i = 0; i < deladSträng.Length; i++)
            {
                if (i % 2 == 0)
                {
                    deladSträng[i] = deladSträng[i].ToUpper();
                }
                else
                {
                    deladSträng[i] = deladSträng[i].ToLower();
                }
            }
            return string.Join(" ", deladSträng);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StoraOchSmåBokstäver("Detta är ett exempel och ett test snälla fungera"));
        }
    }
}