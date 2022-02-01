using System;
using System.Text.RegularExpressions;

namespace Düzenliİfadeler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Regular Expressions Operators
            #region ^ Opeartörü
            //^ Operatörü : Satır başının istenilen ifadeyle başlamasını sağlar.
            //^9 : 99dasdas, 9dsada, 9-*-/2132 ||| dsa999, *-*-**9,
            //string text = "9141hfgjlghopd";
            //Regex regex = new Regex("^91");  -> 91 ile başlayan bir düzeni kurmak için Regex ile oluşturduk bu bize Match dönüyor
            //Match match = regex.Match(text); -> Match ile regex komutlarından match propertysi ile texti kontrol ettik
            //Console.WriteLine(match.Success); -> Dönen sonucu burada kontrol ettik
            #endregion
            #region \ Operatörü
            //\ : Belirli karakter gruplarını içermesini istiyorsak kullanırız.

            //\D : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
            //\d : Metinsel değerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir

            //\W : Metinsel değerin ilgili yerinde alfanumerik olmayan karakterin olması gerektiği belirtilir. Alfanümerik karakterler : a-z A-Z 0-9
            //\w : Metinsel değerin ilgili yerine alfanümerik olan karakterin olacağı ifade edilir.

            //\S : Metinsel değerin ilgili boşluk karakterleri(tab/space) dışında herhangi bir karakterin olamayacağı belirtilir.
            //\s : Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir.

            //ÖRNEK
            //9 ile başlayan ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım
            //^9\d\S

            #endregion
            string text = "9141hfgjlghopd";
            Regex regex = new Regex(@"^9\d\S"); //1. karakter 9 ile başlıcak | 2. karakter 0-9 arası tek bir sayı | 3. karkater ise boşluk olmayacak
            Match match = regex.Match(text);

            Console.WriteLine(match.Success);
            #endregion
        }
    }
}
