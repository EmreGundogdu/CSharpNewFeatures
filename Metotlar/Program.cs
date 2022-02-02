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
        private char Metot5()
        {

        }
        #endregion
        #region Geriye Değer Döndüren, Parametre Alan Metot

        #endregion
    }
}
