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
            //for (int i = 0; i < metin2.Length; i++)
            //{
            //    if (metin2[i] == 'r')
            //        Console.WriteLine(i);
            //}
            int i = 0;
            do
            {
                if (metin2[i] == 'r')
                    Console.WriteLine(i);
                i++;
            } while (i < metin2.Length);
            #endregion
            #region String İfadelerde + Operatörü
            //String ifadelerde + operatörü kullanılabilmektedir
            //İki string ifade arasında birleştirme görevi görür
            string a2 = "Merhaba", b2 = "Dünya";
            Console.WriteLine(a + b);
            //Bir string ifade ile herhangi bir tür + operatörü ile işleme tabi tutulabilir.
            //+ operatörü string bir ifadeyle herhangi bir türdeki ifadeleri işleme tabi tutarken object + string davranışı sergileyecek ve sonuç olarak geriye string değer döndürecektir
            //Dolayısıyla herhangi bir ifadeyi string'e dönüştürebilmek için o ifadeyi + "" ile işleme tutmak yeterli olabilir.
            int a3 = 5;
            // a2 + a3;  -> string + int = string

            Console.WriteLine(5 + 7 + 20 + "emre");
            #endregion
            #region String Formatlandırma
            string isim = "Emre", soyisim = "Gündoğdu", tcNo = "1234567890";
            int yas = 21;
            bool medeniHal = false;
            //Console.WriteLine("Tc No : ......... olan .... ........ şahsın bilgileri | Yaş : .. | Medeni Hal : .....");
            #region  + Operatörü
            Console.WriteLine("Tc No : " + tcNo + " olan " + isim + soyisim + " Şahsın Bilgileri | Yaş : " + yas + "| Medeni Hal : " + (medeniHal ? "Evli" : "Bekar"));
            //+ ile string formatlandırmalarında ternary operatörü kullanılıyorsa bunu parantez içerisine almamız gerekir.
            #endregion
            #region string.Format Fonksiyonu
            string sonuc = string.Format("Tc No : {0} olan {1} {2} şahsın bilgileri | Yaş : {3} | Medeni Hal : {4}", tcNo, isim, soyisim, yas, medeniHal ? "Evli" : "Bekar"); //indexleri belirtip metod içerisine indexlerin karşılığını yazıyoruz
            Console.WriteLine(sonuc);
            #endregion
            #region $(String Interpolation) (C# 6.0)
            //String Interpolation yapısal olarak arkaplanda string.Format fonksiyonuyla sekillenen bir operatördür. Ternary kullanıyorsak parantez içerisine almamız gerekir.
            Console.WriteLine($"Tc No : {tcNo} olan {isim} {soyisim} şahsın bilgileri | Yaş : {yas} | Medeni Hal : {(medeniHal ? "Evli" : "Bekar")}");
            #endregion
            #endregion
            #region String Kaçış Karakterleri
            /*
             *  \o -> Null sonalndıram karakteridir. Genel olarak dosya veya veri kanalının bitişini belirtmek için kullanılır
             *  \a -> Bip sesini çıkartan karakterdir
             *  \b -> Backspace-Geri-Önceki Karakteri Silme
             *  \t -> Tab
             *  \r -> Satır Başı
             *  \n -> Bir alt satıra iner
             *  \v -> Dikey tab
             *  \f -> Sayfa ilerleme
             *  \" -> Çift tırnak
             *  \' -> Tek tırnak
             *  / -> Backslash
             */
            Console.WriteLine("\"Bugün hava çok güzel\""); //"Bugün hava çok güzel" yani çift tırnak içerisinde mesja yazdırabildik
            Console.WriteLine("Emre\\Gündoğdu");
            Console.WriteLine("\a");
            Console.WriteLine("abc\b");
            Console.WriteLine("İsim\tSoyisim\tAdres\t");
            Console.WriteLine("\n");
            #endregion
            #region @(Verbatim Strings) Operatörü
            #region 1. Kullanım
            //Bir değişken yahut metot vs. gibi yapılanma isimlerinin programatik bir keyworde karşılık gelmesi mümkün değildir. Derleyici hatası verir
            //Eğer ki illa ben bir keyword ismi kullanıcam diyorsak eğer @ kullanılabilir.
            int @void = 5;
            int @class = 10;
            int @namespace = 15;
            #endregion
            #region 2. Kullanım            
            //string metin3 = "Hava çok \"güzel\"";
            string metin4 = @"Hava çok ""güzel""";
            #endregion
            #region 3. Kullanım
            string metin5 = "Bugün" +
                " otuz" +
                " ocak";
            string metin6 = @"Bugün 
                                otuz
                                ocak"; //Bu yöntem kullanılır
            #endregion
            #endregion
            #region String Interpolation İle Verbatim Strings Birlikteliği (C# 8.0)
            string isim2 = "Emre", soyisim2 = "Gündoğdu", siparisNo = "123123";
            int fiyat = 100;

            //ÖRNEK
            string mailMessage =
@$"Merhaba {isim2} {soyisim2}
{siparisNo} nolu sipariş talebiniz tarafımızca alınmıştır. 
Fiyat : {fiyat}";
            Console.WriteLine(mailMessage);
            #endregion
            #region String Fonksiyonları
            string metin7 = "Wir sind da";
            #region Contains
            bool sonuc2 = metin7.Contains("da");
            bool sonuc3 = metin7.Contains("wa");
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            #endregion
            #region StartsWith            
            Console.WriteLine(metin7.StartsWith("Wir"));
            #endregion
            #region EndsWith
            Console.WriteLine(metin7.EndsWith("da"));
            #endregion
            #region Equals
            Console.WriteLine(metin7.Equals("Hallo"));
            #endregion
            #region Compare
            //Metinsel ifadeleri karşılaştırmamızı ve sonuç olarak int türde değer elde etmemizi sağlar
            //0 : Her iki değer birbirine eşittir
            //1 : Soldaki sağdakinden alfanumerik olarak büyük
            //-1 : Soldaki sağdakinden alfanumerik olarka küçük
            Console.WriteLine(string.Compare(metin7, "R"));
            Console.WriteLine(string.Compare(metin7, "a"));
            Console.WriteLine(string.Compare(metin7, metin7));
            #endregion
            #region CompareTo
            Console.WriteLine(metin7.CompareTo("Z"));
            Console.WriteLine(metin7.CompareTo("a"));
            Console.WriteLine(metin7.CompareTo(metin7));
            #endregion
            #region IndexOf
            //Verilen değerin string ifade içerisinde olup olmamasını geriye int döndüren bir fonksiyondur
            //Geriye int olarak indexNo'yu döndürür.
            //Eğer sonuç yoksa -1 değerini döndürür
            Console.WriteLine(metin7.IndexOf("nd"));
            Console.WriteLine(metin7.IndexOf("r"));
            Console.WriteLine(metin7.IndexOf("da"));
            Console.WriteLine(metin7.IndexOf(" "));
            //IndexOf ilk eşleşen değerin indexini döndürür
            #endregion
            #region Insert
            //Elimizdeki metinsel ifadeye bir değer dahil etmemizi/eklememizi sağlayan bir fonksiyondur.
            string eklenmisMetin = metin7.Insert(11, " ,Hallo");
            Console.WriteLine(eklenmisMetin);
            //İlgili ekleme operasyonu gerçekleştikten sonra eklenmiş hali string olarak döndürülecektir. Lakin metin orjinal verisi ayri bir şekilde tutulacaktır

            #endregion
            #region Remove
            //Metinsel ifadede indexel olarak verilen değer silen bir fonksiyondur
            //Insertte oldugu gibi ilgili fonksiyon yapmış olduğu işlem neticesinde yeni değeri üreterek bizlere string olarak dönecektir. Elimizdeki veri değişmeyecektir.
            Console.WriteLine(metin7.Remove(8)); //8. indexten sonraki tüm değerleri sil
            Console.WriteLine(metin7.Remove(8, 2)); //8. indexten başla 2 adet sil
            Console.WriteLine(metin7);
            #endregion
            #region Replace
            //Elimizdeki metinsel ifadede belirtlilen değerleri yahut karakterleri, belirtilen diğer değerler ya da karakterler ile değiştirmemizi sağlayan bir fonksiyondur.
            Console.WriteLine(metin7.Replace(" ", "-"));
            //Sonuç olarak string değer üretecek ve geriye döndürecektir.
            #endregion
            #region Split
            //Metinsel ifadeyi verilen değeri ayraç olarak kullanıp, parçayalan ve sonucu string dizisi olarak döndüren bir fonksiyondur.
            string[] dizi = metin7.Split(' ');
            string[] dizi2 = metin7.Split(' ', 'i');
            #endregion
            #region Substring
            //Metinsel ifadenin belirli bir aralığını elde etmemizi sağlar
            Console.WriteLine(metin7.Substring(5));  //5. indexten sonuna kadar tüm değerleri getir
            Console.WriteLine(metin7.Substring(5, 10));  //5. indexten balayacak 10 karakter getirir.
            #endregion
            #region ToLower
            //Elimizdeki metinsel ifadenin tüm karakterlerini küçük karakter olarak düzenler
            Console.WriteLine(metin7.ToLower());
            #endregion
            #region ToUpper
            //Elimizdeki metinsel ifadenin tüm karakterlerini büyük karakter olarak düzenler
            Console.WriteLine(metin7.ToUpper());
            #endregion
            #region Trim
            //Metinsel ifadelerin varsa solundaki ve sağındaki boşluk karakterlerni temizleyen bir fonksiyondur
            Console.WriteLine("      emre    ".Trim());
            #endregion
            #region TrimEnd
            Console.WriteLine("emre         ".TrimEnd());
            #endregion
            #region TrimStart
            Console.WriteLine("       emre".TrimStart());
            #endregion
            #region Örnek
            //Adımızı ilkten 3. Soyadımızın sondan 5. karakterini getirelim
            string adSoyad = "Emre Gündoğdu";
            #region 1. Çözüm
            Console.WriteLine(adSoyad[2]);
            Console.WriteLine(adSoyad[adSoyad.Length - 5]); //sondan 5.
            #endregion
            #region 2. Çözüm
            string aralik = adSoyad[2..^4];
            Console.WriteLine(aralik[0]);
            Console.WriteLine(aralik[aralik.Length - 1]);
            #endregion
            #endregion
            #region 2. Örnek

            #endregion
            #endregion
        }
    }
}
