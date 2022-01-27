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
            //for () değişken & şart & işlem => girmediğmizde sonsuz döngüye girer
            //{
            //    Console.WriteLine("Emre");
            //}
            //7. Varyasyon
            //for (int i = 0; ; i++) şart belirtmezsek yine sonsuz döngüye girer
            //{
            //    Console.WriteLine("Emre");
            //}
            //8. Varyasyon
            for (int i = 0, i2 = 0; i < 10 && i2 < 5; i++, i2++)//birden fazla değişken olduğunda virgül ile ayırmak gerekir
            {
                Console.WriteLine(i);
                Console.WriteLine(i2);
            }
            #endregion
            #region While Döngüsü - For İle Kıyaslama
            //while döngüsünde for gibi çalışabilmek için kombinasyonu kendimiz oluşturmalıyız
            int _i = 0;
            Console.WriteLine("WHİLE");
            while (_i < 10)
            {
                Console.WriteLine("Emre");
                _i++;
            }
            #endregion
            #region While 1. Kritik
            //Ekrana 10 kere "Merhaba Dünya" yazdıran bir program yazalım
            int q = 1;
            while (q <= 10)
            {
                Console.WriteLine("Merhaba Dünya");
                q++;
            }
            #endregion
            #region While 2. Kritik
            //Klavyeden girilen sayıdan geriye doğru 0'a kadar sayan bir sayaç hazırlayalım
            int girilenSayi = int.Parse(Console.ReadLine());
            while (girilenSayi >= 0)
            {
                Console.WriteLine(girilenSayi);
                girilenSayi--;
            }
            #endregion
            #region While 3. Kritik
            //0 ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren programı yazalım
            int d = 0, toplam = 0;
            while (d <= 100)
            {
                if (d % 2 == 1)
                    toplam += d;
                d++;
            }
            Console.WriteLine(toplam);
            #endregion
            #region While 4. Kritik
            //Klavyeden girilen sayının faktöriyelini hesaplayalım
            int f = int.Parse(Console.ReadLine());
            int faktoriyelDegiskeni = 1;
            while (f > 0)
            {
                faktoriyelDegiskeni *= f;
                f--;
            }
            Console.WriteLine(faktoriyelDegiskeni);
            #endregion
            #region While 5. Kritik
            //O anki tarihin saniye değeri 5'in katıysa eğer tarihi ekranda gösteren uygulamayı yazalım
            while (true)
            {
                if (DateTime.Now.Second % 5 == 0)
                    Console.WriteLine(DateTime.Now);
            }
            #endregion
            #region  Do While
            //While Döngüsü : önce şarta bakar sonra kodu çalıştırır
            //Do While Döngüsü : önce kodu çalıştırır sonra şarta bakar - şartın true ya da false olup olmadığına bakmaz do kısmı
            //çalışır

            //While Örnek : Havaya bakarız ona göre şemsiye alırız
            //Do While Örnek : Önce şemsiyeyi alırız sonra havaya bakarız

            while (false)
            {
                Console.WriteLine("While Döngüsü");
            }

            do
            {
                Console.WriteLine("Do While Döngüsü");
            } while (false);
            #endregion
        }
    }
}
