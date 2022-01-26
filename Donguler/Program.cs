using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Döngüler Nedir
            //Console.WriteLine("dasdsa");
            //Console.WriteLine("dasdsa");
            //Console.WriteLine("dasdsa");
            //Console.WriteLine("dasdsa");
            //Console.WriteLine("dasdsa");
            #endregion
            #region For Döngüsü
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
            #region For Döngüsü - 2. Kritik
            //Emre değerini 10 kere ekrana yazalım
            for (int i = 0; i < 50; i += 5)
            {
                Console.WriteLine("Emre");
            }
            #endregion
            #region For Döngüsü - 3. Kritik
            for (int i = 50; i > 0; i -= 5)
            {
                Console.WriteLine("Gundogdu");
            }
            #endregion
            #region For Örnek 1
            //1den 10'a kadar olan sayıları ekrana yaz
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            //Uzun yoldan 1-10 arası yazdırma
            Console.WriteLine("Uzun Yol");
            for (int i = 50; i < 60; i++)
            {
                Console.WriteLine(i - 49);
            }
            #endregion
            #region For Örnek 2
            //1 ile 40(dahil) arasındaki çift sayıları toplayarak sonucu ekrana yazdıralım
            int toplamSonuc = 0;
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine(i); 1-40 arası çift sayıları görmek için                    
                    toplamSonuc += i;
                }
            }
            Console.WriteLine("Toplam Sonuc : " + toplamSonuc);
            #endregion
        }
    }
}
