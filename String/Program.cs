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
        }
    }
}
