using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            #region Non-Trailing Named Arguments
            //Hangi parametreye hangi değerlerinde gönderildiğini direkt görebilmek için bu özelliği kullanırız.
            //Göreceli bir şkeilde çok parametreli fonksiyonlarda hedef parametrelere değer göndermemizi sağlayan bir özelliktir.
            T(3, 5, "abc");
            T(c: "emre", a: 3, b: 5); //farklı sırayala değer ekleme
            #endregion
            #region In Parameters
            //PARAMETRE ÖZELLİKLERİ:
            //1. Parametre değerini metodun içerisinde herhangibir yerde çağırıp kullanabiliri.z
            //2. Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz. Yani parametrenin değerini değiştirebiliriz(Çünkü parametreler özünde bir değişkendir)

            //IN KOMUTU SAYESİNDE parametreye verilen değeri sabit tutabilmekteyiz.
            //In Komutu, metodun parametresini readonly(Sadece okunabilir) hale getirir.
            //In komutunun kullanıldığı parametrelerde eğer ki metot içerisinde farklı bir assign durumu söz konusu olursa derleyici hatası verecektir.
            #endregion
            #region Local Functions
            //Bir metot içerisinde tanımlanmış olan metotlardır!
            //C#'ta metotlar sade ve sadece class içerisinde tanımlanırlar diye söylemiştirk! Halbuki OOP'de göreceğimiz struct, abstract class, interface, record yapılarında da metotlar tanımlanmaktadır. Metotlar bu saydıklarımızın dışında KESİNLİKLE başka bir yerde tanımlanamaz
            //Metotlar KESİNLİKLE metotların içerisinde tanımlamaz demiştik Halbuki C# 7.0'da gelen local function özelliği sayesinde metot içerisinde metot tanımlanabilmektedir.
            #endregion
            #region Local Functions Tanımalam Kuralları
            //1. Erişim belirleyicisi(Access Modifier) yazılmaz!
            //2. Local function olarak tanımlanan fonksiyon adı tanımladığı fonksiyonun adından farklı olmalıdır.! Alsi taktirde derleyici hatası vermez
            #endregion
            #region Local Functions Kullanım Kuralları
            //- Bir local function sade ve sadece tanımlandığı metodun içerisinmde kullanılabilir.
            //- Local function tanımlandığı metodun içerisinde her yerden erişilebilir.
            #endregion
            #region Local Functions Amacı
            //Local function, sadece tek bir metotta tekrarlı bir şekilde kullanılacak bir algoritmayı/kod parçacığını/işlemi o metoda özel bir şekilde tek seferlik tanımlamızı ve kullanmamızı sağlamaktadır.
            #endregion
            #region Local Funtion Muadilleri(Eş anlamlıları)
            //Anonim functions, Delegete functions, Func functions
            #endregion
            #region Method Overloading(Çoklü Yükleme)
            //Overloading: Çoklu Yükleme
            //Bir class içerisinde belirli kurallar çerçevesinde aynı isimde birden fazla metot oluşturmaya Method Overloading denir.
            #endregion
            #region Overloading Kuralları
            //Bir sınıf içerisinde birden fazla aynı isimde metot tanımlayabilmek için şu kurallara dikkat edilmesi gerekir.
            //Metot overloading işlemini yapabilmek için metotların isimleri aynı olmalıdır
            //Bu metotlar içerisinde fark yaratmamız gerekir.
            //Bu fark bizzat metot imzalarında OLMALIDIR
            //Metotlar arasında farkı yaratırken erişim belirleyicileri ve geri dönüş değerleri aktif rol oynamaktadır.
            //Parametre sayıları ya da parametre türleri farklı olmalıdır.
            #endregion
            #region Recursive Fonksiyon 
            //Kendi içerisinde kendisini çağıran/tetikleyen fonksiyonlardır.
            //Özyinelemeli/Tekrarlamalı Fonksiyonlar denebilir.
            //Recursive fonksiyonlar bir yaklaşımdır!
            //Öngürülemeyen, derinliği tahmin edilemeyen, sonu bilinmeyen durumlarda terchil edilebilir. 
            //Dçngülerin kullanıldığı her noktada recursive fonksiyonları kullanabiliriz. Amma velakin, recursive fonksiyonlar kullanıldığı her yerde de döngü KULLANILAMAZ!
            #endregion
            #region Ref Keywordü
            //ref keywordü, referansdan gelmektedir.
            //Referans, OOP kavramıdır
            //OOP'da nesneler(obejct) RAM'de Heap bölgesinde tutulmaktadır.
            //OOP'da referamslar = operatörü ile iletişime geçebilmektedirler. Bir referams, işaretlediği herhangi bir nesneyi = operatörü sayesinde farklı bir referansa işaretletebilir.
            //Yani, refereanslar da = operatörü neticesinde herhangi bir neticelsel/nesnesel türeme söz konusu olmamakta, işaretlemiş nesne diğer referans tarafından işaretlemektedir.
            //Değer türlü değişkenlerde referans çalışması yapmak istiyorsak eğer ref keywordü kullanılır
            //ref keywordü, değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan bir komuttur
            //Değer türlü değişkenlerde shalllow copy yapmamızı sağlayan bir keyworddür
            #region Örnek 1
            int a = 5;
            ref int b = ref a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a *= 5;
            Console.WriteLine(b);
            b -= 10;
            Console.WriteLine(a);
            #endregion
            #region Örnek 2
            int y = 10;
            R(ref y);
            Console.WriteLine(y);
            void R(ref int a)
            {
                a = 25;
            }
            #endregion
            #endregion
            #region Ref Return

            #endregion
            Local();
        }
        void RecursiveMethod()
        {
            //Belirli değer aralığındaki 5'in katı olan tüm sayıları toplayan RECURSIVE fonksiyonu yazalım
            #region 1. Örnek
            int RecursiveTopla(int baslangic, int bitis)
            {
                if (baslangic % 5 == 0)
                    return baslangic + RecursiveTopla(++baslangic, bitis);
                if (baslangic < bitis)
                    return RecursiveTopla(++baslangic, bitis);
                return 0;
            }
            #endregion
            #region 2. Örnek
            List<FileInfo> files = DosyaYazdir("Dosya yolu(c:users/emre/...)");
            foreach (var file in files)
                Console.WriteLine(file.FullName);
            List<FileInfo> DosyaYazdir(string path)
            {
                List<FileInfo> fileInfos = new();
                DirectoryInfo directoryInfo = new(path);
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                if (directoryInfos.Any())
                    foreach (DirectoryInfo directory in directoryInfos)
                        fileInfos.AddRange(DosyaYazdir(directory.FullName));
                else
                    fileInfos.AddRange(directoryInfo.GetFiles());
                return fileInfos;
            }
            #endregion
        }

        public void S(int a, int b)
        {

        }
        public void S(int a)
        {
            int b = 0;
            static void X(int a, int b)
            {
                Console.WriteLine(a); //metoda static ekleyince X metodunu parametrelerini kullanırız. 
                Console.WriteLine(b); //metoda static ekleyince X metodunu parametrelerini kullanırız. 
            }
            X(a, b);
        }
        public static int Local()
        {
            void Y()
            {
                Console.WriteLine("Merhaba");
            }
            Y();
            return 0;
        }
        static void In(in int a, int b, in string c)//metot kullanıldığında a değişkeni bir değer alıcak ve bu değeri metotta değiştirme demek
        {
            //a = 123; HATA vericek çünkü In keywordü ile metot içerisinde a değişkeninin değerini değiştirme durumu söz konusu olamaz
            //c = "Emre"; HATA verir
            b = 50; //hata vermez
        }
        static void T(int a, int b, string c)
        {

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
