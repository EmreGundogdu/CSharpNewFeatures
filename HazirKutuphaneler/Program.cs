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
            #region Floor
            //Ondalıklı değeri tam sayıya dönüştürür. (Her zaman aşağıya yuvarlar)
            Console.WriteLine(Math.Floor(3.15)); //3'e yuvarlar
            #endregion
            #region Round
            //Ondalıklı değerin en yakın tam sayıya yuvarlar
            Console.WriteLine(Math.Round(3.75)); //yukarı yuvarlıcak
            Console.WriteLine(Math.Round(3.5)); //yukarı yuvarlıcak(yarımlar yukarı yuvarlar)
            Console.WriteLine(Math.Round(3.25)); //aşağıya yuvarlıcak
            #endregion
            #region Pow
            //Üssü alma
            Console.WriteLine(Math.Pow(3, 2));//taban 3 üssü 2
            #endregion
            #region Sqrt
            //Karekök
            Console.WriteLine(Math.Sqrt(16)); //16'nın karekökü 4'tür
            #endregion
            #region Truncate
            Console.WriteLine(Math.Truncate(3.14));
            #endregion
            #endregion
            #region DateTime Strcut'ı
            #region Now
            Console.WriteLine(DateTime.Now);//tarih saat ve saniyeye kadar getirir
            #endregion
            #region Today
            Console.WriteLine(DateTime.Today);//sadece tarihi getirir.
            #endregion
            #region Compare
            DateTime tarih1 = new DateTime(2021, 06, 16);
            DateTime tarih2 = new DateTime(2021, 07, 20);
            int result = DateTime.Compare(tarih1, tarih2);
            if (result < 0)
            {
                Console.WriteLine($"{tarih1} küçüktür {tarih2}");
            }
            else if (result == 0)
            {
                Console.WriteLine($"{tarih1} eşittir {tarih2}");
            }
            else
            {
                Console.WriteLine($"{tarih1} büyüktür {tarih2}");
            }
            #endregion
            #region AddDays
            Console.WriteLine(DateTime.Now.AddDays(16));
            #endregion
            #region AddHours
            Console.WriteLine(DateTime.Now.AddHours(100));
            #endregion
            #region AddMonth
            Console.WriteLine(DateTime.Now.AddMonths(20));
            #endregion
            #region AddYears
            Console.WriteLine(DateTime.Now.AddYears(10));
            #endregion

            #endregion
            #region TimeSpan Struct'ı
            DateTime t1 = DateTime.Now;
            DateTime t2 = new DateTime(2000, 1, 1);
            TimeSpan span = t1 - t2;
            Console.WriteLine(span.Days);
            Console.WriteLine(span.Minutes);
            #endregion
            #region Random Sınıfı
            Random random = new Random();
            #region Next Fonksiyonu
            Console.WriteLine(random.Next()); // 0'dan büyük değer üretir
            Console.WriteLine(random.Next(100)); // 0-100 arası değer üretir
            Console.WriteLine(random.Next(50,100)); // 0-100 arası değer üretir
            #endregion
            #region NextDouble Fonksiyonu

            #endregion
            #endregion
        }
    }
}
