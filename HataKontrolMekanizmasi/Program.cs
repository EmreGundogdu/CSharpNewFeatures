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
            #region Exception Dışında Farklı Bir Tür İle Hata Yakalama
            try
            {
                int a1 = 2, a2 = 10;
                int a3 = a1 / a2;

                int.Parse("sdadas"); //Bu senaryoda try catch blogu kullanıldığı halde fiziksel olarak patlama meydana gelmis ve uygulama sona ermis bulunmaktadır. Catch blogu eger ki bir ture özgü ise(genel olmayan) böyle bir durumda sadece o türden hataları yakalayabilen bir yapı haline gelir
            }
            catch (DivideByZeroException ex)//catch blogu bir parametre almazsa eğer tüm hatalı karşılar.Özel bir exception tanımlanmışsa sadece o türe ait bilgileri karşılar
            {
                Console.WriteLine("Mesaj : " + ex.Message);
            }
            #endregion
            #region Birden Çok Catch Durumu 
            try //alınan hatalar sırayla catch bloklarına girer
            {
                int z = 0, z2 = 10;
                int z3 = z / z2; //divide by zero exception
                int.Parse("dsadas"); //format exception
            }
            catch (DivideByZeroException ex) //DivideByZeroException hatası alındığında bu hatayı karşılayacak olan catch bloğu burasıdır
            {

            }
            catch (FormatException ex) //FormatException hatasını karşılayacak olan catch tanımladık
            {

            }
            //Yukarıda ki exception türleri haricinde başka bir türde exception hatası alıcaksak o tür için bir catch bloğu daha yazılmalıdır. Yukarıdaki exception türleri haricinde gelicek olan hata türünü Excetpion İle karşılayabiliriz. Catch bloğunun en sonuna Exception turunde parametre(catch) tanımlarsan alınan hata ustteki turlerden herhangi biri değilse kesinlikle bu Excepiton tarafından karşılanabilir olacağıdan dolayı en kotu buraya girecektir
            catch (Exception ex)// burası en sona yazılmalıdır yani Exception en sona yazılmalıdır. ZORUNDALIKTIR!!!...
            {

            }

            #endregion
            #region Finally Bloğu
            //finally bloğu, try catch yapılanmasında hata alınsada alınmasada her iki durumda da tetiklenmesi/çalıştırılması gereken kodlaru yazdığımız bloktur
            try
            {
                //hata verebilecek kodlar buraya
                Console.WriteLine("try");
            }
            catch
            {
                //hata alındıktan sonra yapılacak işlemler buraya
                Console.WriteLine("catch");
            }
            finally
            {
                //her iki durumda da çalışmasını istediğimiz kodlar buraya
                Console.WriteLine("finally");
            }
            #endregion
            #region When Yapısı İle Hata Filtreleme(C# 6.0)
            //try catch bloklarına when blokları ile şart uygulayabilmekteyiz
            string z = "a";
            try
            {
                int q1 = 0, q2 = 10;
                int q3 = q1 / q2;
            }
            catch (DivideByZeroException ex) when (z == "a")
            {
                Console.WriteLine("Mesaj : " + ex.Message);
            }
            catch (DivideByZeroException ex) when (z == "b")
            {
                Console.WriteLine("Mesaj : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Genel Hata Yakalama");
            }
            #endregion
        }
    }
}
