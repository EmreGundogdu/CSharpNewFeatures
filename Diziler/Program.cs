using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Diziler - Array
            //Tek bir değişken altında birden fazla "aynı türde" değeri toplamamızı sağlayan veri kümelerine dizi denir.
            // [] -> INDEXER OPERATORU -> Dizi değişkeni oluşturur int[] 
            //PROTOİP : type[] name = new type[...];
            //new -> bir dizi nesnesi oluşturmamızı sağlar
            int[] yaslar = new int[5];
            //Dizilerde tanımlama yaparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
            //Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı alan tahsisinde bulunurlar. Bu durumda bellk boyutunda ekstradan maliyete sebep olacağı için bir sınırlılıktır            
            yaslar[0] = 2;
            yaslar[1] = 4;
            yaslar[2] = 6;
            yaslar[3] = 8;
            yaslar[4] = 10;
            //Console.WriteLine(yaslar[2]);

            string[] personeller = new string[10];
            personeller[0] = "Emre";
            personeller[1] = "Fatih";
            personeller[2] = "Serhat";
            personeller[3] = "Mert";
            personeller[4] = "Yaren";
            personeller[5] = "Gamze";
            personeller[6] = "Buse";
            personeller[7] = "Hilal";
            personeller[8] = "İdil";
            personeller[9] = "İrem";
            //Diziler genellikle döngülerle birlikte algoritmalarda kullanılmaktadırlar/işlenmektedirler
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(personeller[i]);
            }
            int x = 0;
            do
            {
                //Console.WriteLine(personeller[x++]);
            } while (x < 10);
            #region Diziyi yazdıran döngü
            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine(personeller[i]);
            }
            #endregion

            #endregion
            #region Sınırlılıklar
            //Dizilerde tanımlama yaparken eleman sayısının bildiirlmesi zorunluluğu bir sınırlılıktır
            //Diziler tanımlandığında kullansakta kullanmasakta bellekte belirtilen eleman sayısı kadar alan tahsisinde bulunurlar. Bu durumda bellek boyunda ekstradan maliyete sebep olacağı için bir sınırlılıktır.
            //Dizilerde eleman sayısının başta belirlenmesi durumunda, ihtiyaca binaen daha fazla değer atamak istediğimizde bu değerleri atayamacağımızdan ve dizinin aralığını genişletemeyeceğimizden dolayı bu durum bir sınırlılık olarak karşımıza çıkmaktadır.
            //Dizilerde elemanlara değer atarken indexeer operatörüyle çok haşır neşir olunmaktadır. Bu durumda bir sınırlılıktır.
            #endregion
            #region Dizi Tanımlama Varyasyonları
            #region 1. Varyasyon
            int[] degerler = new int[5];
            degerler[0] = 1;
            Console.WriteLine(degerler[0]);
            #endregion
            #region 2. Varyasyon
            int[] degerler2 = { 10, 20, 21, 22, 23 };
            string[] isimler = { "Emre", "Fatih", "Serhat" };
            #endregion
            #region 3. Varyasyon
            string[] isimler2 = new string[] { "Emre", "Fatih", "Serhat" };
            #endregion
            #region 4. Varyasyon
            string[] isimler3 = new string[3] { "", "", "" };//belirtilen(3) kadar süslü parantez içerisine değer girmek gerekir.
            #endregion
            #region 5. Varyasyon - Önemli
            int[] sayilar = new[] { 3, 5, 7 };
            var sayilar2 = new[] { 3, 4, 5 }; //int türüne dönüşen bir dizi
            var stringler = new[] { "sda", "ada", "dasda" }; //string türüne dönüşen bir dizi
            #endregion
            #endregion
            #region Array Sınıfı

            Array yaslar2 = new int[3]; //Array = Dizi | Array yerine int[] yazabilirdik
            //Dizi olarak tanımlanan değişkenler Array sınıfından türetilmektedirler.
            //Dizilerde Array sınıfıdan gelen berlirli metotlar ve özellikler mevcuttur

            int[] a = new int[5];//kendi türünde tutuyorsak indexer operatörü kullanılabilir.
            Array a2 = new int[5];//Array türünde tutuyorsak indexer operatörü kullanılamaz
            #endregion
        }
    }
}
