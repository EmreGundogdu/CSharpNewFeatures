using System;

namespace DizilerdeVeriselPerformans
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //int[] sayilar2 = sayilar[2..7];
            //sayilar2[0] *= 10;
            //sayilar2[1] *= 10;
            //sayilar2[2] *= 10;
            //sayilar2[3] *= 10;
            //sayilar2[4] *= 10;
            //string text = "Hallo, wir sind da";
            #region ArraySegment Nedir?
            //Bir dizinin bütününden ziyade belirli bir kısmına yahut parçasına ihtiyaç dahilinde ilgili diziyi kopyalamak yerine(ki görece oldukça maliyetli bir operasyondur) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan bir yapıdır.
            #endregion
            #region ArraySegment İle Dizinin Belli Bir Alanını Referans Etmek
            ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); //Dizinin tüm elemanlarını temsile eder.
            ArraySegment<int> segment2 = new ArraySegment<int>(sayilar, 2, 5); //2. indexten başla 5.'ye kadar(5 sayarken normal 1'den başladık) | 30-50
            segment1[0] *= 10;
            segment2[0] *= 10;
            #endregion
            #region ArraySegment Slicing(Dilimleme)
            //Bir dizi üzerinde birden fazla parçada çalışacaksan eğer herbir parçayı ayrı bir ArraySegment olarak tanımlayabiliriz. Bu tanımlamaların dışında diziyi tek bir arraysegment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz. Yani ilgili diziyi tek bir segment üzerinden daha rahat bir şekilde parçalayabiliriz. Bu durumda bize yazılımsal açıdan efektiflik kazandırmış olacaktır.
            ArraySegment<int> segment = new ArraySegment<int>(sayilar, 2, 5);
            ArraySegment<int> segment3 = segment.Slice(0, 3);
            ArraySegment<int> segment4 = segment.Slice(4, 7);
            ArraySegment<int> segment5 = segment.Slice(5, 10);
            #endregion
            #region StringSegment Nedir?
            //StringSegment, ArraySegment'in string değerler nezdindeki bir muadildir.
            //Esasında metinsel değerlerdi birçok analitik operasyonlardan bizleri kurtarmakta ve Substring vs. gibi fonksiyonlar yerine string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.
            string text = "Hallo, wir sind da";
            #endregion
        }
    }
}
