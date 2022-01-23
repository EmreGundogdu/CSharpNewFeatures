﻿using System;

namespace AkisKontrolYapilandirilmalari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch Case
            //Switch Case kodun akışında belirli bir şarta göre yönlendirme yapmamızı(farklı algoritma çalıştırmamızı/farklı operasyon gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır. 
            //Switch Case yapılanması bir değişkenin değerini sadece eşitlilk durumlarını kontrol ederken kullanılabilir.
            //Sadece eşitlik durumu kontrol edilecekse o zaman siwtch kullanılabilir.
            string adi = "Emre";
            switch (adi) //kontrol edilen değerin türü ne ise case bloklarında aynı türde degerlerle kontrol edilir.
            { //Swtich parantezine değişken yazılabilirken | case bloklarına değişken ismi yazılamaz
                case "Emre":
                    Console.WriteLine("Adı Emre");
                    break;
                case "Yaren":
                    Console.WriteLine("Adı Yaren");
                    break;
                case "Fatih":
                    Console.WriteLine("Adı Fatih");
                    break;
                default: //Case bloklarından hiçbiri eşleştirmeye uymuyorsa eger varsa default blogu tetiklenir
                    Console.WriteLine("Hiçbiri Değil");
                    break;
            }
            //Case bloklarının sıralaması ve defaultun yerleştirildiği yer önemli değildir.
            #endregion
            #region When
            int satisTutari = 1000;
            switch (satisTutari)
            {
                case 1000 when (3 == 5): //when ifadesi &(ve) mantığı oluşturur iki tarafta true olması yani eşitlik olması gerekir

                    break;
                case 1000 when (3 == 3):

                    break;
            }
            #endregion
            #region goto
            int i = 10;
            switch (i)
            {
                case 5: 
                    Console.WriteLine(i * 10);
                    break;
                case 6:
                    Console.WriteLine(i / 5);
                    break;
                case 7:
                    //Console.WriteLine(i * 10);
                    //break;
                    Console.WriteLine(i * 10);
                    break; 
                case 10:
                    //Console.WriteLine(i * 10);
                    //break;
                    goto case 5; //case 5te ki kodu çalıştırmış oluruz. goto kullanılan case'de komutunu kullanmıyoruz


                    //case 7 :
                    //case 10 :
                        //goto case 5; //yukarıdaki gibi gibi farklı caseler oluşturmak yerine case 7 ve case 10u bu şekilde yazıp daha sonra gidicek olan case'Yi goto ile kullanıyoruz
            }
            #endregion
        }
    }
}