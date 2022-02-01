﻿using System;

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
        }
    }
}
