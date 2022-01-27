using System;

namespace Keywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Keyword : Programlama dilinin en atomik parçalarıdır diyebiliriz
            #region Yardımcı Manevratik Komutlar
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
            #endregion

        }
    }
}
