using System;

namespace Metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Metodun Geriye Değer Döndürmesi Ne Demektir
            int sonuc = Topla(5, 8);
            if (sonuc > 10)
                Console.WriteLine("Sonuç 10'dan büyük");
            bool sonuc2 = PersonelEkle("Emre", "Gndgd", 21);
            #endregion
            X(5, 10, 15);
            Y();
            #region Başka Sınıfta Tanımlanmış Bir Metodun Kullanımı
            Matematik matematik = new Matematik(); //Class isimli bir değişken ise bu referans'tır.
            Console.WriteLine(matematik.Topla(5, 10));
            Console.WriteLine(matematik.Carp(5, 10));
            Console.WriteLine(matematik.Cikar(10, 5));
            Console.WriteLine(matematik.Bol(10, 5));
            #endregion
        }
        #region Örnek döngü
        //int[] sayilar = new int[10];
        //for (int i = 0; i < sayilar.Length; i++)
        //{
        //    sayilar[i] = new Random().Next();
        //}
        //foreach (var sayi in sayilar)
        //{
        //    Console.WriteLine(sayi);
        //}
        #endregion
        //Metotlar class içerisinde oluşturulmalıdır.

        //Metot Oluşturma
        //erişim belirleyicisi   geri dönüş değeri   metodun adı()
        //{
        //}


        #region Geriye Değer Döndürmeyen, Parametre Almayan Metot
        private void Metot1()
        {
            //döngüler vs yapılabilir.
            Console.WriteLine("Geriye Değer Döndürmeyen, Parametre Almayan Metot Oluşturuldu");
        }
        #endregion
        #region Geriye Değer Döndürmeye, Parametre Alan Metot
        public void Metot2(int a)
        {

        }
        public void Metot3(int a, bool b)
        {

        }
        public void Metot4(int a, int b, char c)
        {

        }
        #endregion
        #region Geriye Değer Döndüren, Parametre Almayan Metot
        //Geriye değer döndüren fonksiyonlarda, bildirilen türde bir değer döndürebilmek için return keywordü kullanmamız gerekir.
        //return : nerede tetiklenir işlenirse orada ilgili fonksiyondan/metotdan çıkılır.
        private char Metot5()
        {
            return 'a';
        }
        private int Metot6()
        {
            if (DateTime.Now.Second > 10) //bu şekilde hata verir çünkü if'in false olma durumunda ne yapacağını bilmez.
                return 5;

            return 10;  // -> false durumdaki durumu eklemiz gerekir.
        }
        #endregion
        #region Geriye Değer Döndüren, Parametre Alan Metot
        public bool Metot7(int x)
        {
            return true || false;
        }
        public int Metot8(int x)
        {
            return DateTime.Now.Year > 2000 ? 1 : 0;
        }
        #endregion

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        static public bool PersonelEkle(string adi, string soyadi, int yas)
        {
            if (yas >= 20)
            {
                //... Veritabanına eklendi
                return true;
            }
            else
            {
                Console.WriteLine("Personel 20'den küçük olamaz!");
                return false;
            }
        }
        #region Optional Parameters(İsteğe Bağlı Parametreler)
        //Metot parametrelierne =(assign) operaötür ile bir değer atanırsa eğer o parametreye varsayılan değeri atanmış olur. Haliyle opsiyonel parametre haline getirilmiş olunur. 
        #region Kritik 1
        //Tüm parametreler opsiyonel olabilir
        #endregion
        #region Kritik 2 
        //Birden fazla parametre durumunda OPSİYONEL olanlar sağ tarafta TANIMLANMALIDIR!!!;
        #endregion
        #region Kritik 3
        public static void X(int a, int x, int y, int b = 2, int c = 4)
        {

        }
        #endregion

        #endregion
        #region Tanımlanmış Metodun Kullanılması
        //Tetikleme = Çağırma = Kullanım
        #region Tanımlandığı Sınıf İçerisinde Kullanımı
        //Bir metot tanımlandığı sınıf içerisindeki farklı bir metot içerisinden çağrılacaksa eğer tek yapılması gereken sadece isminin çağılrılmasıdır/tetiklenmesidir/çalıştırılmasıdır.        
        #endregion
        #endregion
        public static void Y()
        {

        }

    }
    class Matematik
    {

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }
    class Ornek
    {
        public void A()
        {
            B();
        }
        private void B()
        {
            C(5);
        }
        private int C(int a)
        {
            return a;
        }

    }
}
