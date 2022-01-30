using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String
            //string : referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
            int a = 5; // değer türlü
            string b = "Emre"; // string b => STACK'te tutulur | "Emre" değeri HEAP'te tutulur REFERANS TÜRLÜDÜR
            #endregion
            #region Null - Empty, Farkları
            #region Null
            //Bir değişken/nullable/referans eğer ki null alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis etmediği anlamına gelir.
            //Heapte referansı oluşturulmadı
            //Değer türlü değişkenler null alamazlar
            //Değer türlü değişkenlerin null alabilmesi için nullable(?) olmaları gerekir.

            int? d = null;
            string c = null; //string referans türlüdür

            //NULL DEĞER ÜZERİNDE BİR İŞLEM YAPMAYA ÇALIŞTIĞIMIZDA RUN TİME HATASI MEYDANA GELİR.
            #endregion
            #region Empty
            //Bir değişken/nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir.
            //Heapte referansı var ama değeri empty
            //Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur

            int g = 0; // empty
            bool f = false; // empty
            int[] x = new int[5]; //Empty durum 5 elemanlık yer ayırdır
            //Empty dendiğinde aklımıza string'e "" değerinin verilmesi gelsin



            //Empty oluşturma : 
            string h = ""; //hem böyle 
            string h2 = string.Empty; //hemde böyle oluşturabiliriz

            //EMPTY OLAN BİR DEĞER ÜZERİNDE İŞLEM GERÇEKLEŞEBİLİR.
            #endregion
            #endregion
            #region IsNullOrWhiteSpace
            //IsNullOrWhiteSpace fonksiyonu : Elimizdeki string ifadenin null, empty yahut boşluk karakterlerinden ibaret olma durumunda geriye bool true değerini döndüren bir fonksiyondur.
            string x3 = "           ";
            if (!string.IsNullOrWhiteSpace(x3))
            {
                //Operasyon
            }

            #endregion
            #region String RAM(Heap) İlişkisi
            string x4 = "dasdas";
            #endregion
            #region String - char Dizisi
            //String ifadeler esasında bir char dizisidir. Yani yazılım açısıdan string ifade yoktur! Esasında karakterlerin bir araya gelmiş hali vardır. Dolayısıyla karakterleri bir araya getirebilecek yegane şey bir dizidir. String ifadeler yazılımsal açıdan bilgisayarda bir char dizisi olarak tarif edilmekte ve o şekilde tutulmaktadır.
            //String ifadeler özünde bir char dizisi/yani dizi olmasından dolayı referans türlü değişkendir. Çünkü diziler referans türlüdürler. Yani nesnedirler. Yani heapte tutulur.
            string metin = "wir sind da";
            //String ifadeler char dizisi olduklarından dolayı yapısal olarak her bir karakter baştan sona otomati indexlenmektedir. Dolayısıyla string bir ifade üzerinde indexer operatöründe kullanabilmekteyiz
            Console.WriteLine(metin[0]);
            Console.WriteLine(metin.Length);
            // Array array = metin; String özünde bir char dizisi olabilir ama yapısal olarak yine de string oldupu için Array referansına atılamaz, Array ile karşılanamaz
            #endregion
            #region Döngülerle String Metin İçerisindeki Herbir Karaktere Ulaşma
            string metin2 = "wir sind da...";
            for (int i = 0; i < metin2.Length; i++)
            {
                if (metin2[i] == 'r')
                    Console.WriteLine(i);
            }
            #endregion
        }
    }
}
