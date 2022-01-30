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
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}
            //int x = 0;
            //do
            //{
            //    Console.WriteLine(personeller[x++]);
            //} while (x < 10);
            #region Diziyi yazdıran döngü
            //for (int i = 0; i < personeller.Length; i++)
            //{
            //    Console.WriteLine(personeller[i]);
            //}
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
            //int[] degerler = new int[5];
            //degerler[0] = 1;
            //Console.WriteLine(degerler[0]);
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

            int[] a = new int[5];//kendi türünde tutuyorsak indexer operatörü kullanılabilir. bu şeklde açlışıldığında ilgili diziye verisel müdahaleler operatif gerçekleştirilir. Bu format algoritmalarda tercih edilir indexer kullanılabilir olduğundan dolayı.
            Array a2 = new int[5];//Array türünde tutuyorsak indexer operatörü kullanılamaz. Bu şekilde çalışılırken ise fonksiyonel çözümler getirilmektedir.



            #endregion
            #region Array Türünden Dizilere Değer Atama / Okuma
            #region 1. Yöntem
            int[] dizi = new int[2];
            dizi[0] = 20;
            dizi[1] = 10;
            Array dizi2 = dizi;
            #endregion
            #region 2. Yöntem
            //Array dizi3 = new int[] { 1, 2, 3, 4, 5 };
            //Array dizi4 = new int[2] { 1, 2 };
            Array dizi5 = new[] { 1, 2, 3, 4 };
            #endregion
            #region 3. Yöntem
            Array dizi7 = new int[3];
            dizi7.SetValue(5, 0);
            dizi7.SetValue(10, 1);
            dizi7.SetValue(15, 2);
            #endregion
            #region Okuma
            object value = dizi.GetValue(1);//object olarak değeri verir
            #endregion
            #endregion
            #region Array Sınıfı Clear Metodu
            //Dizi içerisindeki tüm elemanları siliyor diye bilinir. Halbuki bu yanlıştır. Dizi içerisindeki tüm elemanlara, dizinin türüne uygun default değerleri atayan bir fonksiyondur

            Array isimler4 = new[] { "emre", "fatih", "serhat", "yaren" };
            for (int i = 0; i < isimler4.Length; i++)
                Console.WriteLine(isimler4.GetValue(i));
            Array.Clear(isimler4, 0, isimler4.Length); //temizlenecek array ismi | hangi indexten başlıcak? | nereye kadar silicek
            Console.WriteLine("********"); //Clear sonrası
            for (int i = 0; i < isimler4.Length; i++)
                Console.WriteLine(isimler4.GetValue(i));
            #endregion
            #region Array Sınıfı Copy Metodu
            Console.WriteLine("******COPY******");
            //Elimizdeki bir dizinin verilerini bir başka diziye kopyalamamızı sağlayan bir fonksiyondur
            Array isimler5 = new[] { "Emre", "fatih", "serhat", "yaren" };
            string[] isimler6 = new string[isimler5.Length];
            Array.Copy(isimler5, isimler6, 4);
            for (int i = 0; i < isimler6.Length; i++)
            {
                Console.WriteLine(isimler6[i]);
            }
            #endregion
            #region Array Sınıfı IndexOf Metodu
            //Dizi içerisinde bir elemanın var olup olmadığını sorgulayabildiğimiz fonksiyondur
            //Arama neticesinde ilgi değer varsa int olarak o değerin index numarasını döndürecektir. Yoksa -1 değerini döndürür
            Console.WriteLine("IndexOf*************************");
            int index = Array.IndexOf(isimler5, "Emre");
            int index2 = Array.IndexOf(isimler5, "Emre", 0, 2);
            if (index != -1)
                Console.WriteLine("Var");
            if (index2 == 0)
                Console.WriteLine("Emre Var");
            #endregion
            #region Array Sınıfı Reverse Metodu
            //Elimizdeki dizinin elemanlarını tersine sıralayan bir fonksiyondur            
            for (int i = 0; i < isimler5.Length; i++)
            {
                Console.WriteLine(isimler5.GetValue(i));
            }
            Array.Reverse(isimler5);
            Console.WriteLine("*****************REVERSE******************");
            for (int i = 0; i < isimler5.Length; i++)
                Console.WriteLine(isimler5.GetValue(i));
            #endregion
            #region Array Sınıfı Sort Metodu
            for (int i = 0; i < isimler5.Length; i++)
                Console.WriteLine(isimler5.GetValue(i));
            Array.Sort(isimler5);
            Console.WriteLine("************SORT*************");
            for (int i = 0; i < isimler5.Length; i++)
                Console.WriteLine(isimler5.GetValue(i));
            #endregion
            #region Array Sınıfı IsReadonly Propertysi
            //Bir dizinin sadece okunabilir olup olmaıdğını bool türde bildiren bir özelliktir
            Console.WriteLine(isimler5.IsReadOnly);
            #endregion
            #region Array Sınıfı IsFixedSize Propertysi
            //Bir veri kümesinin eleman sayısının sabit olup olmama durumunu IsFixedSize ile öğrenebilirz. Tüm dizilerde eleman sayısı sabit olduğu için sürekli true dönercektir. Örneğin ArrayList koleksiyonunda false dönmektedir.
            Console.WriteLine(isimler5.IsFixedSize);
            #endregion
            #region Array Sınıfı Length Propertysi
            Console.WriteLine(isimler5.Length);
            #endregion
            #region Array Sınıfı Rank Propertysi
            int[,,] x = new int[3, 4, 5];//3. dereceği
            Console.WriteLine(isimler5.Rank);
            Console.WriteLine(x.Rank);
            #endregion
            #region Array Sınıfı CreateInstance Metodu İle Dizi Tanımalama
            int[] yaslar3 = new int[3];
            //Normalde yukarıda ki gibi yapılan dizi tanımlaması esasında arkaplanda Array sınıfının CreateInstance metodunu kullanmaktadır. Bizlerde bu metodu kullanarak fonksiyonel diziler oluşturabiliyoruz.
            Array yaslar4 = Array.CreateInstance(typeof(int), 3);//int türünde ve 3 elemanlı
            #endregion
            #region CreateInstance ile Çok Boyutlu Dizi Tanımlama
            Array dizi9 = Array.CreateInstance(typeof(int), 5, 3, 5, 6, 7, 8); //6. dereceli bir dizi ve değerleri 5,3,5,6,7,8'dır
            Console.WriteLine(dizi9.Rank);
            #endregion
            #region Ranges and Indices - System Index
            //Index = ^ işaretidir. Bu (^) Operatörü Index ile kullanılır
            //Index index = ^3; //^ operatörü ile terisne index durumları kullanılırken index değerinin 0'dan değil 1'den başlar.
            int[] sayilar3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Index index3 = 5; --> Soldan 0 - (n-1)
            Index index3 = ^4; //---> Sağdan 1'den başlar sola doğra gider.
            Console.WriteLine(sayilar3[index3]);
            #endregion
            #region Ranges and Indices - Range
            int[] _sayilar = { 3, 5, 7, 9, 1, 2, 321, 534, 5643, 457, 56, 78 };
            //Range range = 5..10;
            //var sonuclar = _sayilar[range];

            //Range range = ..;  ---> Tüm diziye karşılık gelir.
            //var _sayilar2 = _sayilar[range];
            //_sayilar2[0] = 100;

            //Range range = 5..^3;  ^3 = sağdan 3 sayıp geldikten sonra bir sonrakini alır
            //var _sayilar2 = _sayilar[range];

            Range range = ^8..^3; // ^3 = sağdan 3 sayıp geldikten sonra bir sonrakini alır
            var _sayilar2 = _sayilar[range];
            #endregion
            #region .. Operatörü 
            int[] sayilar10 = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
            Index i1 = 5, i2 = 10;
            Range _range = i1..i2;
            var degeler = sayilar10[range];
            #endregion
            #region ^ Operatörü
            //^ Operatörünü kullanmak için Index türü ile çalışmak gerekir.
            int[] sayilar11 = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
            Index f = ^3; //Index türü kullanıldı
            Console.WriteLine(sayilar11[f]); // 457 verdi

            Range range3 = ^7..^2; // 31, 321, 534, 5643, 457 değerlerini bize verir
            #endregion
            #region Çok Boyutlu Diziler
            //Çok boyutlu diziler oyun programlamada yahut yüksek istatiksel çalışmalarda kullanılan bir yapıdır
            //type[,] -> Iki boyutlu bir dizi tanımlaması(Çift)
            //type[,,,] -> 4 Boyutlu dizi tanımlaması
            //Çok boyutlu dizilerde indexer içerisinde virgül ile tanımlama yapılmaktadır.
            //Iki boyutlu diziler x ve y koordinatlarıyla taahhül edeceğimiz noktalardır
            int[,] b = new int[3, 5];
            #endregion
            #region 2 Boyutludan Fazla Dizi Tanımalaması
            //Iki dereceli'den fazla olan dizileri günlük haytta tahayyül etmek pek mümkün olmasada programatik olarak inşa edebilmekteyiz.
            int[,,,] c = new int[3, 4, 5, 6];
            #endregion
            #region Tanımlanmış Çok Boyutlu Diziye Değer Atama Ve Okuma
            #region 2. Dereceli Dizi Örneklendirme
            int[,] d = new int[3, 4];
            d[1, 2] = 5; //x'i 1 | y'si 2 olan konuma değer atamış olduk
            d[2, 3] = 10; //x'i 2 | y'si 3 olan konuma değer atamış olduk
            #endregion
            #region Çok Dereceli Dizi Örneklendirme
            int[,,,] e = new int[3, 4, 5, 6];
            e[0, 0, 0, 0] = 15; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 15 değerini ata
            e[0, 0, 0, 1] = 16; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 16 değerini ata
            e[0, 0, 0, 2] = 17; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 17 değerini ata
            e[0, 0, 0, 3] = 18; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 18 değerini ata
            e[0, 0, 0, 4] = 18; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 18 değerini ata
            e[0, 0, 0, 5] = 19; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 19 değerini ata
            e[1, 0, 0, 5] = 10; //1. derecenin & 2. derecenin ve 3. derecenin 4.nün birinci hücresine 15 değerini ata
            #endregion
            #region 3. Dereceli Örnek
            int[,,] g = new int[3, 4, 5];
            g[0, 0, 1] = 15; //x'i 0 y'si 0 z'si 1
            g[2, 3, 2] = 16; //x'i 2 y'si 3 z'si 2
            g[1, 3, 4] = 17; //x'i 1 y'si 3 z'si 4
            #endregion
            #region Varyasyonla Değer Atama
            int[,] t =
            {
                {3,5,7 }, //3 boyutlu dizi olduğu ilk verilen değerde belirlendi
                {5,6,7 },
                {15,36,27 },
                {20,23,13 }
            };
            #endregion
            #region Çok Boyutlu Dizilerden Değer Okuma
            int[,] h = new int[4, 3];
            h[0, 0] = 3;
            h[0, 1] = 5;
            h[0, 2] = 7;
            h[1, 0] = 9;
            h[1, 1] = 6;
            h[1, 2] = 2;
            h[3, 2] = 8;
            Console.WriteLine(h[1, 0]); //9
            Console.WriteLine(h[0, 2]); //7

            Console.WriteLine(h.Rank);//kaç dereceli olduğunu gösterir
            Console.WriteLine(h.Length); //toplam hücre sayısına göre belirlenir. Yani h dizinde oluşturduğumuz (4*3) bize sonucu verir.

            Console.WriteLine(h.GetLength(0));  //4
            Console.WriteLine(h.GetLength(1));  //3
            #endregion
            #endregion
            #region Çok Boyutlu Dizilerdeki Verileri İç İçe Döngülerle Ekrana Yazdırma
            int[,,] _sayilar3 = new int[2, 2, 4];
            _sayilar3[0, 0, 0] = 1;
            _sayilar3[0, 0, 1] = 2;
            _sayilar3[0, 0, 2] = 3;
            _sayilar3[0, 0, 3] = 4;
            _sayilar3[0, 1, 0] = 5;
            _sayilar3[0, 1, 1] = 6;
            _sayilar3[0, 1, 2] = 7;
            _sayilar3[0, 1, 3] = 8;
            _sayilar3[1, 0, 0] = 9;
            _sayilar3[1, 0, 1] = 10;
            _sayilar3[1, 0, 2] = 11;
            _sayilar3[1, 0, 3] = 12;
            _sayilar3[1, 1, 0] = 13;
            _sayilar3[1, 1, 1] = 14;
            _sayilar3[1, 1, 2] = 15;
            _sayilar3[1, 1, 3] = 16;
            for (int i5 = 0; i5 < _sayilar3.GetLength(0); i5++)
            {
                for (int j5 = 0; j5 < _sayilar3.GetLength(1); j5++)
                {
                    for (int p5 = 0; p5 < _sayilar3.GetLength(2); p5++)
                    {
                        Console.Write(_sayilar3[i5, j5, p5] + "           ");
                    }
                    Console.WriteLine("");
                }
            }
            #endregion
            #region Dizi İçerisinde Dizi Tanımlama/Düzensiz Diziler/Dizi Dizileri
            //Düzensiz diziler herbir elemanı kendi içerisinde farklı bir dizi barındıran dizilerdir.
            //Çok boyutlu dizilerden tek farkı, çok boyut dizilerin sütun sayılarının sabit, halbuki düzensiz dizilerin ise sütun sayılarının değişken olmasıdır
            //type[][] --> type dizisi türünde bir dizi olucak
            int[][] _sayilar6 = new int[3][]; //2 dereceli - 3 elemanlı
            _sayilar6[0] = new int[3] { 3, 5, 7 }; //0. indexe böyle 3 elemanlı bir dizi verdik
            _sayilar6[1] = new int[5] { 3, 5, 7, 321, 42 }; //1. indexe 5 elemanlı bir dizi veridk
            _sayilar6[2] = new int[10] { 3, 5, 7, 32, 13, 11, 22, 32, 32, 23 }; //2. indexe 10 elemanlı bir dizi verdik
            #endregion
        }
    }
}
