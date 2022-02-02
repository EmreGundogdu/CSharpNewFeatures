using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek döngü
            //int[] sayilar = new int[10];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = new Random().Next();
            //}
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion
            //Metotlar class içerisinde oluşturulmalıdır.

            //Metot Oluşturma
            //erişim belirleyicisi   geri dönüş değeri   metodun adı()
            //{
            //}




        }

        //erişim belirleyici   geri dönüş değeri   metot adı()

        //Dört Farklı Türde metot oluşturma;

        #region Geriye Değer Döndürmeyen, Parametre Almayan Metot
        private void Metot1()
        {
            //döngüler vs yapılabilir.
            Console.WriteLine("Geriye Değer Döndürmeyen, Parametre Almayan Metot Oluşturuldu");
        }
        #endregion
        #region Geriye Değer Döndürmeye, Parametre Alan Metot
        public void Metot2(int a)
        {

        }
        public void Metot3(int a, bool b)
        {

        }
        public void Metot4(int a, int b, char c)
        {

        }
        #endregion
        #region Geriye Değer Döndüren, Parametre Almayan Metot
        //Geriye değer döndüren fonksiyonlarda, bildirilen türde bir değer döndürebilmek için return keywordü kullanmamız gerekir.
        //return : nerede tetiklenir işlenirse orada ilgili fonksiyondan/metotdan çıkılır.
        private char Metot5()
        {
            return 'a';
        }
        private int Metot6()
        {
            if (DateTime.Now.Second > 10) //bu şekilde hata verir çünkü if'in false olma durumunda ne yapacağını bilmez.
                return 5;

            return 10;  // -> false durumdaki durumu eklemiz gerekir.
        }
        #endregion
        #region Geriye Değer Döndüren, Parametre Alan Metot

        #endregion
    }
}
