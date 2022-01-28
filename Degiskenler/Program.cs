using System;

namespace Degiskenler
{//namespace scope
    class Program
    {//class scope
        static void Main(string[] args)
        { //main scope
            #region C# Dil Özellikleri
            //C# DİL ÖZELLİKLERİ            
            /*
             *c# büyük-küçük harf duyarlılığı vardır 
             *tip güvenliği vardır(rame eklenecek verinin tipini belirliyoduk)
             */
            #endregion

            Console.WriteLine("Hallooo");
            #region Değişkenler Oluşturma/Tanımlama
            //degisken_turu degisken_adi;
            string adi;
            bool medeniHal;
            string soyadi;
            int yas;
            #endregion
            #region Ram Yapısı
            //iki yapılanma vardır (STACK | HEAP)
            //STACK : Değer türlü değişkenleri ve değerleri tutar(değişken türü,adı ve değeri tutar) & metod isimleri || burada tutulan değişken ismine referansta denebilir
            //HEAP : Nesneleri tutar 
            int yas1; //1
            string adi2; //2
            string soyadadi3; //3
                              //bunlar stackte sırasıyla tutulur.
                              //FIFO -> First in first out (ilk giren ilk çıkar)
            #endregion
            #region Değişken Tanımlama Kuralları
            //Anlamlı İsimlendirme
            int personelYas;
            string personelİsim;
            //Özel Karakterler olmamalı
            double stok_adedi;
            //Sayısal İfadeler
            int sayi2;
            int sayi3;
            //Bir scope içerisinde aynı isimde birden fazla değişken tanımlanamaz!!!
            #endregion
            #region İsimlendirme Kuralları
            //Pascal Case
            int TcNo;
            //Camel Case
            int orderId;
            bool satisDurumAdi;
            string userName;
            //Snake Case
            string kullanici_adi;
            int bir_sayinin_degeri;
            #endregion
            #region Değişken İsmini @ Operatörü İle Tanımlama
            //değişken isimlerinde programatik keyword kullanılamaz. Eğer programatik keword kullanmak istersek başına @ koymalıyız
            string @static;
            string @x;

            #endregion
            #region Tanımlanmış Değişkene Değer Atama ve Tanımlama Aşamasında Değer Atama
            int a;
            a = 5;
            //******
            string musteriAdi = "";
            string musteriSoyad = "";
            char karakter = 'g';
            //Bir değişkene atanan en son değer geçerlidir
            int c;
            c = 10;
            c = 20;
            c = 30;
            Console.WriteLine(c);
            #endregion
            #region Değişkene Değer Atama Kuralları
            //Metinsel 
            string adSoyad = "Emre Gundogdu";
            //mantıksal
            bool evliMi = true;
            //sayısal
            float d = 14.5f;
            int g = 5;
            byte h = 3;
            #endregion
            #region Tuple Türüyle Değiken Atama
            (int z, int x) v = (3, 5);
            (int ogrenciYasi, string adres,bool medeniHali) kisi = (21,"Eskişehir",false);
            #endregion
            #region Literal Duzenleme
            int duzenlenmis = 1_000_000; //daha okunabilir hale gelmiş oluyo c# 7.0dan önce yoktu (yani araya _ ile okunabilirliği arttımış olduk)
            #endregion
            #region Değişken türüne default değer atama
            bool asd = default(bool); //default değer false
            int asdf = default(int); //default değeri 0
            string asfg = default(string); //default dğer null
            char asdsa = default(char); //default değer /0
            #endregion
            #region Tanımlanmış değişkenin değerini okuma
            int mmm = 5;
            int nnn = 10;
            int ööö = nnn; // 10 | 5
            int ççç = mmm; // 5
            nnn = mmm; // 5 
            ööö = nnn; //5

            #endregion
        }
    }
}
