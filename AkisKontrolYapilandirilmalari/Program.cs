using System;

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
            #region Switch Expression
            #region Eski Yöntem
            string isim = "";
            int z = 10;
            switch (z)
            {
                case 5:
                    isim = "Emre";
                    break;
                case 7:
                    isim = "Ahmet";
                    break;
                case 10:
                    isim = "dasdas";
                    break;
            }
            #endregion
            #region Yeni Yöntem
            int sayi = 10;
            string isim2 = sayi switch
            {
                5 => "Yavuz",
                7 => "Burak",
                10 => "Emre"
            };

            #endregion
            #endregion
            #region Switch Expression & When
            int sayi1 = 20;
            string isim1 = sayi1 switch
            {
                20 when 3 == 3 => "Emre",
                var x when x == 7 && x % 2 == 1 => "Gündoğdu",
                5 when 2 != 3 => "String İfade",
                var x => "Hiçbiri" //default : Hiçbirinin olmadığı durumda default tanımlamasına karşılık gelecektir.
            };
            #endregion
            #region Switch Expression & Tuple Patterns
            int _sayi1 = 20;
            int _sayi2 = 21;
            string mesaj2 = "";
            switch (_sayi1, _sayi2)
            {
                case (20, 21):
                    mesaj2 = "20 ve 21 değerleri";
                    break;
                case (5, 10):
                    mesaj2 = "5 ve 10 değerleri";
                    break;
            }
            Console.WriteLine(mesaj2);
            string mesaj3 = (_sayi1, _sayi2) switch
            {
                (20, 21) when (true) => "20 ve 21 değerleri",
                (10, 20) => "10 ve 20 değerleri"
            };
            #endregion
            #region if
            bool medeniHal = true;
            if (medeniHal == true)
            {
                Console.WriteLine("Evlisin");
            }
            else
            {
                Console.WriteLine("Evli Değilsins");
            }
            //if yapılanması tek başına kullanılıyorsa sadece şarta bağlı olarak çalışacak kod odaklanır...
            #endregion
            #region If Kritik 1
            //if yapılanmasında illa ki else kullanmak zorunda değiliz
            int c = 10;
            if (c != 10)
            {
                Console.WriteLine("Merhaba");
            }

            #endregion
            #region If Kritik 2
            bool medeniHal1 = true;
            if (medeniHal1)
            {
                Console.WriteLine("Evlisin");
            }
            #endregion
            #region If - Else
            int v = 10;
            if (v > 5)
            {
                Console.WriteLine("v değeri 5'ten büyüktür");
            }
            else
            {
                Console.WriteLine("v değeri 5'ten küçüktür");
            }
            #endregion
            #region If - Else Kritik 1
            int b = 10;
            if (b != 10)
            {
                Console.WriteLine("b değeri 10 değildir");
            }
            else
            {
                Console.WriteLine("b değeri 10dur");
            }
            if (b == 10)
            {
                Console.WriteLine("b değeri 10dur");
            }
            else
            {
                Console.WriteLine("b değeri 10 değildir");
            }
            #endregion
            #region If - Else Kritik 2
            //her iki durumda da ortak olacak olan/calistirilacak olan komutlari if-else kod bloklarının dışına yazılmalıdır
            int n = 10;
            if (n == 10)
            {
                Console.WriteLine("n değeri 10dur");
            }
            else
            {
                Console.WriteLine("n değeri 10 değildir");
            }
            Console.WriteLine("Merhaba");
            #endregion
            #region If - Else - If
            int m = 50;
            if (m > 5 && m <= 10)
            {
                Console.WriteLine(m * 5);
            }
            else if (m > 10 && m <= 20)
            {
                Console.WriteLine(m * 10);
            }
            else if (m > 10 && m == 50)
            {
                Console.WriteLine("Doğru kod bloğuna girdi");
            }
            else
            {
                Console.WriteLine("Diğer şartlar çalışmadı");
            }
            #endregion
            #region If - Else - If Kritik 1
            int sayi2 = int.Parse(Console.ReadLine());//210 sayısı girdik diyelim
            //if (sayi2 > 100 && sayi2 <= 200)
            //{
            //    Console.WriteLine("100 ile 200 arasında");
            //}
            //else if (sayi2 > 200 && sayi2 <= 300) //buraya 
            //{
            //    Console.WriteLine("200 ile 300 arasında");
            //}
            //else if (sayi2 > 200 && sayi2 <= 400) //ve buraya girmesini isteriz
            //{
            //    Console.WriteLine("200 ile 400 arasında");
            //}

            if (sayi2 > 100 && sayi <= 200)
            {
                Console.WriteLine("100 ile 200 arasında");
            }
            if (sayi > 200 && sayi2 <= 400)
            {
                Console.WriteLine("200 ile 400 arasında");
            }
            if (sayi2 > 200 && sayi <= 400)
            {
                Console.WriteLine("200 ile 400 arasında");
            }
            #endregion
            #region If - Else - If - ... - Else
            int sayi3 = 100;
            if (sayi3 < 100)
            {
                Console.WriteLine("100'den küçük");
            }
            else if (sayi3 > 100)
            {
                Console.WriteLine("100'den büyük");
            }
            else
            {
                Console.WriteLine("100'e eşit");
            }
            #endregion
            #region Scopesuz If Yapısı
            if (true)
                Console.WriteLine("A");
            //eğer ki birden fazla konsept/islem/operasyon barındıracaksa bunları kesinlikle scope içersine almamız gerekmektedir.
            #endregion
            #region If Senaryo
            //klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL'den fazla ise, 2. üründen 25 indirim yaparak ödenecek tutarı gösteren uygulamayı yazalım.
            Console.Write("Lütfen Birinci Ürünün Fiyatını Giriniz : ");
            int birinciUrunFiyati = int.Parse(Console.ReadLine());
            Console.Write("Lütfen İkinci Ürünün Fiyatını Giriniz : ");
            int ikinciUrunFiyati = int.Parse(Console.ReadLine());
            #region 1. Kritik
            //int toplam = birinciUrunFiyati + ikinciUrunFiyati;
            //if (toplam > 200)
            //{

            //}
            #endregion
            #region 2. Kritik
            if (birinciUrunFiyati + ikinciUrunFiyati > 200)
            {
                //int toplamSonTutar = birinciUrunFiyati + (ikinciUrunFiyati * 75 / 100);
                //Console.WriteLine(toplamSonTutar);
                Console.WriteLine(birinciUrunFiyati + (ikinciUrunFiyati * 75 / 100));
            }
            else
            {
                Console.WriteLine(birinciUrunFiyati + ikinciUrunFiyati);
            }
            #endregion
            #endregion
            #region If Senaryo 2
            //Belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı", yanlış girildiğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren Console uygulamasını yazalım.
            Console.WriteLine("Lütfen Kullanıcı Adını Yazınız");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz");
            string sifre = Console.ReadLine();
            if (!(kullaniciAdi == "gndgd" && sifre == "12345"))
                Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
            else
                Console.WriteLine("Giriş Başarılı");

            Console.WriteLine(kullaniciAdi == "gndg" && sifre == "12345" ? "Giriş Başarılı" : "Girdiğiniz kullanıcı adı veya şifre hatalı");
            Console.WriteLine("****************");

            Console.WriteLine("Lütfen adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("lütfen şifre giriniz");
            string parola = Console.ReadLine();
            switch (ad, parola)
            {
                case ("gndgd", "12345"):
                    Console.WriteLine("Giriş Başarılı");
                    break;
            }
            Console.WriteLine("Giriş başarısız");


            #endregion
            #region If Senaryo 3
            //Kullanıcıdan alınan iki sayının ve yapılacak işlem türünün(toplama, çıkarma, çarpma, bölme) seçilmesiyle, sonucu hesaplayan programı yazalım
            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            int sayi5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            int sayi6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lüfen yapılacak işlemi belirtiniz (+, -, *, /)");
            char islem = char.Parse(Console.ReadLine());
            #region 1. Kritik
            //if (islem == '+')
            //{
            //    Console.WriteLine(sayi5 + sayi6);
            //}
            //else if (islem == '-')
            //{
            //    Console.WriteLine(sayi5 - sayi6);
            //}
            //else if(islem == '*')
            //{
            //    Console.WriteLine(sayi5 * sayi6);
            //}
            //else
            //{
            //    Console.WriteLine(sayi5 / sayi6);
            //}
            #endregion
            #region 2. Kritik
            switch (islem)
            {
                case '+':
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    break;
            }
            #endregion
            #region 3. Kritik
            //diğer kritiklere göre daha efektik bir kod yazmış olduk
            int sonuc = islem switch
            {
                '+' => sayi5 + sayi6,
                '-' => sayi5 - sayi6,
                '*' => sayi5 * sayi6,
                '/' => sayi5 / sayi6,
                _ => sayi5 + sayi6
            };
            Console.WriteLine(sonuc);
            #endregion
            #region 4. Kritik
            Console.WriteLine(islem == '+' ? sayi5 + sayi6 : (islem == '-' ? sayi5 - sayi6 : (islem == '/' ? sayi5 / sayi6 : sayi5 * sayi6)));
            #endregion
            #endregion
            #region If Senaryo 4
            //Girilen sayının değeri 10 değilse ekrana 'sayı yanlış' yazdıralım
            int sayi7 = int.Parse(Console.ReadLine());
            #region Kritik
            if (sayi7 == 10)
            {

            }
            else
            {
                Console.WriteLine("sayı yanlış");
            }
            #endregion
            #region Kritik 2
            if (sayi7 != 10)
            {
                Console.WriteLine("sayı yanlış");
            }
            #endregion
            #region Kritik 3
            Console.WriteLine(sayi7 == 10 ? "sayı doğru" : "sayı yanlış");
            #endregion
            #endregion
            #region If Senaryo 5
            //Girilen sayının negatif ya da pozitif olduğunu gösteren uygulamayı yazalım
            int sayi8 = int.Parse(Console.ReadLine());
            string _sonuc = "";
            if (sayi8 < 0)
                //Console.WriteLine("Negatif");
                _sonuc = "Negatif";
            else
                //Console.WriteLine("Pozitif");
                _sonuc = "Pozitif";
            

            #endregion
        }
    }
}
