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
        }
    }
}
