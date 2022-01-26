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
            #region For Örnek 3
            //klavyeden girilen sayının faktöriyelini bulan programı yazalım
            int sayi = int.Parse(Console.ReadLine());
            #region 1. Cozum
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine("Faktöriyel : " + faktoriyel);
            #endregion
            #region 2. Cozum
            int _faktoriyel = 1;
            string sonuc = "";
            for (int i = sayi; i > 0; i--)
            {
                _faktoriyel *= i;
                sonuc += i + (i == 1 ? " = " : " x ");
                //if (i == 1)               
                //    sonuc += i + " = ";
                //else                //
                //    sonuc += i + " x ";
                //
            }
            Console.WriteLine("Faktöriyel : " + sonuc + _faktoriyel);
            #endregion
            #endregion
            #region Varyasyonlar
            //1. Varyasyon
            for (int i = 0; i < 10; i++)
            {

            }
            //2. Varyasyon
            int x = 0; // değişken dışarıda tanımlanır
            for (; x < 10; x++)
            {

            }
            //3. Varyasyon
            int y = 0;
            for (y = 0; y < 10; y++) //Bu varyasyonda dıaşrıda tanımlanan y değişkenini for dongusunde başlangıç değeri olarak göstermek sitiyorsak eğer yine bir başlangıç değeri zorunludur.
            {

            }
            //4. Varyasyon
            int t = 0;
            for (; t < 10;)
            {
                t++;
            }
            //5. Varyasyon
            int a = 10;
            for (int i = 0; a != i * 2; i++) //5e kadar döngü döner
            {
                Console.WriteLine("Emre");
            }
            //6. Varyasyon
            #endregion
        }
    }
}
