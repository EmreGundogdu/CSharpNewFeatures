using System;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Keyword : Programlama dilinin en atomik parçalarıdır diyebiliriz
            //YARDIMCI MANEVRATİK KOMUTLAR
            #region Break
            //Switch-case ve döngülerde kullanılabilir bi keyworddür. Kullanıldığı yapıdan çıkış yapmayı. Sonlandırmayı yarayan keyworddür.
            //switch (10)
            //{
            //    case 5:
            //        break;
            //    case 10:
            //        break;
            //    case 15:
            //        break;
            //}
            //while (true)
            //{
            //    break;
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    break;
            //}
            //foreach (var item in collection)
            //{
            //    break;
            //}
            //for (int i = 0; i < length; i++)
            //{
            //    while (true)
            //    {
            //        break;
            //    }
            //    break;
            //}
            //do
            //{
            //    if (true)
            //    {
            //        break;
            //    }
            //} while (true);
            //TRY CATCH BLOĞUNDA BREAK KULLANILAMAZ ANCAK BİR DONGU ICERISINDE TANIMLANAN TRY CATCH BLOGUNDA KULLANILABİLİR
            //while (true)
            //{
            //    if (DateTime.Now.Second == 20)
            //        break;
            //    Console.WriteLine(DateTime.Now);
            //}
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++) //j'yi 1 yapar ancak 
                {
                    if (j == 1) //1 oldğunda break olucağı için bize 0 değeri verir yani j değeri brekaten önce 1 olur ama yazdırmaz 
                        break;
                    Console.WriteLine("i : " + i + " j : " + j);
                }
            }
            #endregion
            #region Break Örnek
            //Kullanıcıdan 't' harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu ekrana yazdıran uygulamayı yazalım
            int toplam = 0;
            while (true)
            {
                Console.WriteLine("Lütfen Bir Sayı Giriniz.");
                string girilenDeger = Console.ReadLine();
                if (girilenDeger == "t")
                {
                    Console.WriteLine("Toplam Sonuc : " + toplam);
                    break;
                }
                else
                {
                    toplam += int.Parse(girilenDeger);
                }
            }
            #endregion
            #region Break Örnek 2
            //Kullanıcıdan alınan sonsuz adet sayı değerlerinden 37'nin katı girildiğinde sonlanan uygulamayı yazalım
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi % 37 == 0)
                {
                    Console.WriteLine("Uygulama sonlanmıştır");
                    //durum = !durum;
                    break;
                }
            }
            #endregion
            #region Continue
            //Sadece döngülerde erişelibilen ve döngülerde kullanılan bir keyworddür.
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;//2'ye bölümünden kalan 0 olmayanları atlar
                }
            }
            #endregion
            #region Continue Örnek
            //Kullanıcının girdiği sonsuz adet sayıdan pozitif olanlarını çarpan ve 't'(enter) yapıldığında sonucu ekrana yazdıran kodu yazalım
            int carpim = 1;
            while (true)
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                string girilenDeger = Console.ReadLine();
                if (girilenDeger == "t")
                {
                    Console.WriteLine(carpim);
                    break;
                }
                //else
                //{
                int sayi = int.Parse(girilenDeger);
                #region 1. Algoritma
                //if (sayi > 0)
                //{
                //    carpim *= sayi;
                //}
                #endregion
                #region 2. Algoritma
                if (sayi < 0)
                    continue;
                carpim *= sayi;
                #endregion
                //}
            }
            #endregion
            #region Continue Örnek 2
            //1 ile 1000 arasında 7'nin katı olmayan sayıları ekrana yazdıralım
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 7 == 0)
                    continue;
                Console.WriteLine(i);
            }
            #endregion
            #region Return
            //Metot içerisinde olduğu takdirde heryerde kullanılabilir/erişilebilir bir keyworddür
            //İki işlevi görmektedir.
            //1- Nerede çağrılıyorsa çağrılsın bulundugu metottan çıkış yapar yani metodu sonlandırır.
            //2- Geriye değer döndürme sorumluluğunuda üstlenen bir keyworddür
            while (true)
            {
                switch (10)
                {
                    case 10:
                        return;
                        break;
                }
            }
            #endregion
            #region Return Örnek
            //kullanıcı 'c' tuşuna basana kadar sonsuz döngüde dönen uygulamayı yazınız.
            while (true)
            {
                if (Console.ReadKey().KeyChar == 'c') //tuşu girdiğimiz zaman uygular readline kullandığımızda enter'a basınca uygular
                {
                    Console.WriteLine("Uygulama Sona Erdi");
                    return;
                }
                Console.WriteLine("Uygulama çalışıyor...");
            }
        #endregion
        #region Goto
        //Kodun senkranizasyonunu bozup, akisi ters istikamette alamızı sağlayan bir manevratik komuttur
        //switch case yapılanmasında dahili olarak kullanılan bu komut metot içerisinde heryerde kullanılabilir
        //switch (10)
        //{
        //    case 5:
        //        Console.WriteLine("5");
        //        break;
        //    case 10:
        //        goto case 15;
        //    case 15:
        //        break;
        //}
        a:
            Console.WriteLine("Merhaba");
            Console.WriteLine("Dünya");
            goto a;
            #endregion
            #region goto Örnek
            //1'den 100e kadar yazalım
            int y = 1;
        x:
            Console.WriteLine(y++);
            if (y != 100)
                goto x;

            //for (int i = 0; i < 100; i++)
            //    Console.WriteLine(i);
            #endregion
            #region Goto Kritik
            b:
            for (int i = 0; i < 100; i++)
            {
                goto b;
            }
            #endregion
        }
    }
}
