using System;
using System.Collections;

namespace ForeachVeIterasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Iterasyon - Döngü
            //Foreach(Iterasyon) BİR DÖNGÜ DEĞİLDİR
            ArrayList sayilar = new ArrayList { 3, 123, 42, 63, 53, 123, 51, 23 };
            foreach (object item in sayilar)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
