using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aritmetik Operatorler
            // +
            // -
            // *
            // /
            // % -> Mod | Bir sayıyı bir sayıya böldüğümüzde kalan değeri verir
            int a = 2, b = 5;
            int sonuc = a + b;

            double c = 123;
            double c2 = 321;
            double sonuc2 = c + c2;

            decimal s1 = 3214;
            decimal s2 = 32141;
            decimal sonuc3 = s1 + s2;
            #endregion
            #region (int) * (double) = ?
            //iki farklı türde sayısal değer üzerinde yapılan aritmetik işlem neticesinde sonuç olarak büyük olan türde dönecektir
            int s3 = 10;
            double s4 = 5; //double daha büyüktür int'ten ve sonuç double olur
            double sonuc5 = s3 + s4;
            #endregion
            #region (byte) + (int) = ?
            int z = 3; //int byte'den büyük olduğu için sonuç int çıkacaktır
            byte z2 = 5;
            int sonuc6 = z + z2;
            #endregion
            #region (byte) + (byte) = ?
            byte x = 5;
            byte x2 = 10; //iki byte sayısal değer ile işlem yapıldığında sonuç int çıkar bu bir istisnadır
            int sonuc7 = x + x2;
            #endregion
            #region Karşılaştırma Operatörleri
            // < (küçüklük) - soldaki sağdakinden küçük
            // > (büyüklük) - soldaki sağındakindne büyük
            // >= (küçük veya eşitlik) - soldaki sağdakinden küçü veya eşit
            // <= (büyk veya eşit) - soldaki sağdakiden büyük veya eşit
            // == (eşitlik)
            //Karşılaştırma operatorlerinin sonucu true yada falsedir
            #endregion
            #region Karşılaştırma Operatorlerinin Geriye Dönuş Değeri
            //sonuç her zaman booleandir
            int i1 = 3213;
            int i2 = 321412;
            Console.WriteLine(i1 < i2);
            #endregion
            #region  Mantıksal Operatörler
            //Tüm şartları değerlendirip, kendine göre sonuç döndüren operatörlerdir.
            #endregion
            // ve &&
            #region ve operatörü
            //tüm şartların yerine getirilmesine ister yani hepsi true olması lazım
            #endregion
            //veya ||
            #region veya operatörü
            //şartlardan en az birinin yerine getirilmiş olması gerekir.
            //yani en az birinin true olması gerekir | ikisinden biri true olması gerekir
            #endregion
            //ya da  ^
            #region ya da operatörü
            //şartlardan kesinlikte bir tanesinin tanesinin yerine getirilmesi gerekir.
            #endregion
            #region Mantıksal Operatörlerin Kullanım Mantığı
            bool patates = true, kofte = true;
            bool sonuc0 = patates && kofte;
            bool sonuc01 = patates || kofte;
            bool sonuc02 = patates ^ kofte;
            Console.WriteLine(sonuc0);
            Console.WriteLine(sonuc01 + " ve'nin sonucu");
            Console.WriteLine(sonuc02 + " ya da nın sonucu");
            #endregion
            #region Mantıksal Operatörlerin Geriye Dönüş Değeri
            //ve
            Console.WriteLine(true && true); //true
            Console.WriteLine(false && false); //false
            Console.WriteLine(true && false); //false
            //veya
            Console.WriteLine(true || true); //true
            Console.WriteLine(true || false); //true
            Console.WriteLine(false || false);//false
            //ya da 
            Console.WriteLine(true ^ false); //true
            Console.WriteLine(true ^ true); //false 
            Console.WriteLine(false ^ false);//false
            #endregion
            #region Artttırma Azaltma Operatörleri
            //++
            int q1 = 5;
            //q1++; önce q1 değerini döndürür sonra q1 değerine +1 ekler (cw ile yazdırdığımızda ekranda 5 yazar ama bellekte sonucu 6'dır)
            //++q1;  önce q1 değerine +1 ekler sonra q1 değerini döndürür
            Console.WriteLine(q1++); //sonuç 5 | Bellekte 6
            Console.WriteLine(++q1); //sonuç 7 | Bellekte 7

            int t1 = 5;
            int t2 = t1++;
            Console.WriteLine(t1); // 6  olucak Çünkü t2'nin değerini t1++ yani 6 yaptı sonra cw ile yazınca sonuç 6 oldu
            Console.WriteLine(t2); // 5 olucak önce t1 değeri sonra ++ operatörü kullanıldığı için bize 5 değerini verir bellekte 6'dır

            int w1 = 5;
            int w2 = ++w1;
            int w3 = w1;
            w2 = ++w2;
            Console.WriteLine(w1); // 6
            Console.WriteLine(w2); // 7 
            Console.WriteLine(w3); // 6
                                   //--

            #endregion
            #region Üzerine Ekleme Yığma Operatörleri
            // +=
            // -=
            // *=
            // /=
            // %=
            #endregion
            #region Metinsel İfadelerle Operatörler
            // + Operatörü
            //Metinsel ifadeler + operatörü ile birleştirilebilir
            string v1 = "Emre", v2 = "Gundogdu";
            Console.WriteLine(v1 + v2);

            //ORNEK
            int sayi = 5;
            string kelime = "asdas";
            Console.WriteLine(sayi.ToString() + kelime);

            //+= Operatörü
            string ifade = "Emre";
            string ifade2 = "Gundogdu";
            //string x5 = ifade + ifade2;
            //Console.WriteLine(x5);
            ifade += ifade2;

            //== Operatörü
            string degisken = "Emre"; //Burada metinsel ifadeleri karşılaştırdık
            string degisken2 = "Gundogdu";
            bool _sonuc = degisken == degisken2;
            Console.WriteLine(sonuc);

            // !=
            bool _sonuc2 = degisken != degisken2;
            Console.WriteLine(_sonuc2);
            #endregion
            #region ! Operatörü
            //DEGİL yani olumsuzluk anlamı katar
            Console.WriteLine(!true);
            int _sayi = 5;
            int _sayi2 = 7;
            //Console.WriteLine(_sayi != _sayi2);
            Console.WriteLine(!(_sayi == _sayi2));
            #endregion
            #region Ternary Operatörü
            //Bir değişkene/metoda/property'e değer atarken, eğer ki bu değer şarta göre fark edecekse
            //satır bazlı/tek satırda bu şart kontrolünü yaparak duruma göre dğer döndürmemizi sağlayan 
            //kalıpsal operatördür
            // ? "checked" : "checked değil";
            bool medeniHal = true;
            string mesaj = medeniHal == true ? "Evlilere kampanya" : "Bekarlara kampanya";
            Console.WriteLine(mesaj);

            //Birden fazla şartlı Örnek

            int _yas = 25;
            //Yaşı 25'den küçük olanlara A, 25 olanlara B, 25'den büyük olanlara C değeeri döndüren ternary operatörünü oluşturalım
            string _islemSonucu = _yas < 25 ? "A" : (_yas == 25 ? "B" : "C");


            //Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştriniz.
            //deger < 3                      =>  deger * 5
            //deger > 3 && deger > 9          =>  deger * 3
            //deger < 3 && deger % 2 == 0     =>  deger * 10
            //deger < 2 == 1                 =>  deger 
            //hiçbiri değilse               => -1 döndürsün
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            //string girilenSayi = Console.ReadLine(); Kullanıcının girdiği değeri strng olarak getiren/yakalayn bir komuttur.
            //int _deger = int.Parse(girilenSayi);
            int _deger = int.Parse(Console.ReadLine());
            int _ornekSonuc = _deger < 3 ? _deger * 5 : 
                (_deger > 3 && _deger < 9 ? _deger * 3 : 
                (_deger > 9 && _deger % 2 == 0) ? _deger * 10 :
                (_deger % 2 == 1 ? _deger : -1));
            Console.WriteLine("Sonuc : " + _ornekSonuc);


            //Hava durumu tutan string değişkenin değerine göre aşağıdaki önergeleri uygulayan programı yazın
            //"Yağmurlu" -> "Şemsiye alsın"
            //"Güneşli" ->"Bol bol D vitamini alır"
            //"kapalı" -> "Yağmur yağabilir"
            string havaDurumu = "Yağmurlu";
            Console.WriteLine(havaDurumu == "Yağmurlu" ? "Şemsiyeni almalısın" :(havaDurumu == "Güneşli"? "Bol bol D vitamini alsın" : "Yağmur Yağabilir"));
            #endregion
            //Atama (assign) operatörü --- int a = 5;
            #region (Member Access - Üye Erişim) Operatörü (.)
            //Member Access, elimizdeki bir değerin türüne uygun elemanların/fonksiyonların/metotların/propertylerini/field erişmemizi
            //çalıştırmamızı/çağırmamızı sağlayan bir operatörü.
            //Member Access kodun devamını getirir
            int p = 5;
            Console.WriteLine(p.ToString());
            #endregion
            #region Cast Operatörü
            //Genellikle tür dönüşümlerinde kullanılan bir operatördür
            //1. Boxing - > Unboxing
            //2. Bilinçli Tür Dönüşümü
            //3. Chat -> int | int -> char (ASCII)
            #endregion
            #region sizeOf Operatörü
            //Verilen türün bellekte kaç bytelık yer kapladığını int olarak geriye döndürür.
            Console.WriteLine("int: " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("decimal: " + sizeof(decimal));
            #endregion
            #region typeOf Operatörü
            //Verilen değerin type'ini yani türünü getirir
            //O tür ile ilgili bilgileri edinmek için kullanılan bir operatördür
            Type t = typeof(int); //int türüne ait tüm bilgiler t değişkenine atanmıştır.
            Console.WriteLine(t.Name); //int32
            Console.WriteLine(t.IsPrimitive); //true
            Console.WriteLine(t.IsClass); //false
            Console.WriteLine(t.IsValueType); //true
            #endregion
            #region default Operatörü
            //Belirtilen türün default değerini döndüren operatördür
            //Default Değer : Default değerler her tür için yazılım tarafında tanılanmış varsaylın değerlerdir
            //sayısal = 0
            //bool = false
            //string = null
            //char = \0
            //referans = null
            Console.WriteLine(default(int)); //0
            Console.WriteLine(default(string));
            Console.WriteLine(default(Program));
            Console.WriteLine(default(short)); // 0
            Console.WriteLine(default(char));

            int i = default;
            int i3 = default(int);
            #endregion
            Console.WriteLine("is operatörü");
            #region is Operatörü
            //Boxinge tabi tutulmuş bir değerin öz türünü öğrenebilmek/kontrol edebilmek için kullanılan bir operatördür
            //is operatörü denetleme neticesinde durumu bool yani true ya da false olarak döndürecektir.
            object o = true; //Boxing
            Console.WriteLine(o is bool); //true
            Console.WriteLine(o is int);
            Console.WriteLine(o is Program);
            #endregion
            #region is null Operatörü
            //Bir değişkenin değerinin null olup olmamasını kontrol eden ve sonuç olrak geriye bool türünden bir değer döndüren operatördür
            string y = "Emre";
            Console.WriteLine(y is null);
            //is null operatörünü sadece null olabilen türlerde kullanılabilmektedir.
            //int türüne null değeri verilmez | int b = null olmaz/kullanılamaz

            #endregion
            #region is not null Operatörü
            //Elimizdeki değerin null olup olmamasıyla ilgilenmekte ve geriye bool sonuç döndürür
            string h = "Emre";
            Console.WriteLine(h is not null);
            //Sadece null alabilen türlerde kullanılabilir
            #endregion
            #region as Operatörü
            //cast operatörüne alternatiftir
            //cast operatörü unboxing işlemine alternatif olarak üretilmiş bir operatördür
            //CAST
            object k = "Emre";
            string k2 = (string)k;
            Console.WriteLine(k2);
            //AS
            object l = "Emre";
            string l2 = l as string;
            Console.WriteLine(l2);
            #endregion
            #region ?(Nullable) Operatörü
            //C# Dilinde değer türlü değişkenler normal şartlarda null değer alamazlar
            //Bir değer türlü değişkenin null değer alabilmesi için ? operatörünün kullanılması gerekir
            //Prototip : degisken_turu? degisken_adi; bu şekilde ? kulannınca null değer alabilir
            int? u = null;
            bool? u2 = null;
            Console.WriteLine(u is null);
            Console.WriteLine(u2 is not null);
            //bir değer türlü değişken nullable yapıldıysa eğer; is null,is no null,as gibi null ile çalışan operatörler üzerine çalışabiliriz
            object n = 123;
            int? n2 = n as int?;
            #endregion
            #region ??(Null-Coalesing) Operatörü
            //elimizdeki değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür
            //string a = null;
            //a ?? "Merhaba"; -> a degiskenin degeri null degilse a'nin degerini yazdırır, yok eger null ise "Merhaba" yazdırır.
            //iki taraf değeri aynı olmalı | a = string & merhaba = string
            #endregion
            #region ??=(Null-Coalesing Assigment)Operatörü
            string g = null;
            Console.WriteLine(g ??= "Merhaba"); //g'in değeri null ise merhaba yazdır ve merhaba değerini g'ye ata
            //null değil ise g'nin değerini yazdırrırs

            //int? id = null;
            //id ??= 1; id değeri null ise 1 değerini ata, yok eğer değilse değerini koru
            #endregion
        }
    }
}
