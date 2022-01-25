using System;

namespace HataKontrolMekanizmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hata Kontrol Mekanizmları
            //3 tür hata tipi vardır
            //1. Derleyici/Sözdizi hataları
            //2. Runtime hataları
            //3. Mantıksal hatalar

            //Syntax Error
            /*
             * Dil kurallarına aykırı olan hatalar
             */
            #endregion
            #region Çalışma Zamanı Hata Durumaları Örnek
            //Console.Write("Lütfen Birinci Sayıyı Giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Toplam : " + (sayi1 + sayi2));
            #endregion
            #region Try Catch
            #region Try Catch Iskelet Yapısı
            try
            {
                //Olası çalışma zamanı hatarlını barındıran/verebilecek olan kodları buraya yazıyoruz
            }
            catch
            {
                //try içeerisinde bir hata söz konusu olduğunda catch bloğu tetiklenecektir.
                //hataya dair; log, kullanıcı bilgilendirme, kontrlü kapanış vs.
            }
            #endregion
            Console.Write("Lütfen Birinci Sayıyı Giriniz");
            int sayi1 = 0, sayi2 = 0;
            try
            {
                sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Lütfen İkinci Sayıyı Giriniz");
                sayi2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Toplam : " + (sayi1 + sayi2));
            }
            catch
            {
                Console.WriteLine("Lütfen doğru bir ifade giriniz");
            }

            #endregion
            #region  Try Catch Hata Parametreleri
            //Çalışma zamanında alınan hataya dair bizlere bilgi veren/taşıyan parametredir.

            //DivideByZeroException
            int s1 = 0, s2 = 10;
            int a = s2 / s1;
            //Run time'da hata alındığında bunu editörde görebiliriz. Burada görülen DivideByZeroException bizim aldıgımız/karşılaştığuımız hatanın türünü ifade etmektedir.


            //NullReferenceException  -> Null değerine sahip bir değişken üzerinden işlem yapmaya çalıştık
            object x = null;
            x.ToString();


            //FormatException -> String formatını uygun olmayan int formatına döndürmeye çalıştık
            int.Parse("dasdasdas");


            try
            {
                int s3 = 0, s4 = 0;
                int a2 = s3 / s4;
            }
            catch (Exception ex)  //Exception:Bizlere hatayla ilgili tüm bilgileri getirecek olan bir üst türdür.
            {
                Console.WriteLine("Mesaj  : " + ex.Message);
            }
            #endregion
        }
    }
}
