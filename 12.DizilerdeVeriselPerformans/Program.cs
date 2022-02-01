using Microsoft.Extensions.Primitives;
using System;
using System.Text;

namespace DizilerdeVeriselPerformans
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            string text = "Hallo, wir sind da";
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
            ArraySegment<int> segment4 = segment.Slice(0, 3);
            ArraySegment<int> segment5 = segment.Slice(0, 1);
            #endregion
            #region StringSegment Nedir?
            //StringSegment, ArraySegment'in string değerler nezdindeki bir muadildir.
            //Esasında metinsel değerlerdi birçok analitik operasyonlardan bizleri kurtarmakta ve Substring vs. gibi fonksiyonlar yerine string değerde hedef kesit üzerinde işlem yapmamızı sağlayan bir türdür.

            #endregion
            #region StringSegment İle Dizinin Belli Bir Alanını Referans Etmek
            //StringSegment türünü kullanabilmek için uygulama Microsoft.Extension.Primitives paketinin yüklenmesi gerekmektedir.
            StringSegment stringSegment = new StringSegment(text);
            StringSegment stringSegment1 = new StringSegment(text, 2, 5); //L işe başlıcak ,'e kadar
            Console.WriteLine(stringSegment1);
            #endregion
            #region StringBuilder Sınıfı
            string isim = "Emre";
            string soyİsim = "Gündoğdu";
            Console.WriteLine(isim + soyİsim);
            //StringBuilder, string birleştirme operasyonlarında + operatörüne nazaran yüksek maliyeti absorbe edebilmek için arkaplanda StringSegment algoritmasını kullanan ve bu algoritma ile bialere ilgili değerleri olabilecek en az maliyetle birleştirip döndüren bir Sınıftır

            StringBuilder builder = new StringBuilder();
            builder.Append(isim);
            builder.Append(" ");
            builder.Append(soyİsim);
            Console.WriteLine(builder.ToString());
            #endregion
            #region Span Türü
            Span<int> span = new Span<int>(sayilar);
            Span<int> span2 = sayilar;
            Span<int> span3 = new Span<int>(sayilar, 3, 5); //3. indesten sonra 5 tane al.
            Span<int> span4 = sayilar.AsSpan();
            Span<int> span5 = sayilar.AsSpan(3, 5);

            ReadOnlySpan<char> readOnlySpan = text.AsSpan();
            ReadOnlySpan<char> span6 = text;
            #endregion
        }
    }
}
