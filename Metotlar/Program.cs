using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = new Random().Next();
            }
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
