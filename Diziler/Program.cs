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

            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine(personeller[i]);
            }
            #endregion
        }
    }
}
