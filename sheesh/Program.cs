using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett visst antal tal gånger varanda. Exempel: 5*3*8 \n");
            string text = Console.ReadLine();

            string[] tal = text.Split("*");
            int[] intTal = Array.ConvertAll(tal, int.Parse);

            int store = 1;

            for(int i = 0; i < intTal.Length; i++)
            {
                store = intTal[i] * store;
            }

            Console.Write(store);
        }
    }
}
