using System;

namespace HazirKutuphaneler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Math Sınıfı
            #region Abs
            //Mutlak değer işlemi yapar
            //Absoulte Value
            int abs = Math.Abs(5);
            int abs1 = Math.Abs(-5);
            #endregion
            #region Ceiling
            //Ondalıklı değeri tam sayıya dönüştürür. (Her zaman yukarıya yuvarlar)
            Console.WriteLine(Math.Ceiling(3.15)); //4'e yuvarlar
            #endregion
            #endregion
        }
    }
}
