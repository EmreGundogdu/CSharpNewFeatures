using System;
using System.Collections;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            #endregion
            #region ArrayList Koleksiyonu Tanımlama
            //Diziler tanımlanırken kaç eleman tutacakları bildirilmek zorunludur.
            int[] yaslar = new int[15];
            ArrayList _yaslar = new ArrayList();
            #endregion
            #region Tanımlanmış Koleksiyona Değer Atama
            for (int i = 0; i < 15; i++)
            {
                yaslar[i] = i + 10;
                _yaslar.Add(i + 10);
            }
            #endregion
            #region Tanımlanmış Koleksiyondan Değer Okuma
            //Diziler
            Console.WriteLine(yaslar[5]);

            //Koleksiyonlar
            Console.WriteLine(_yaslar[5]);
            #endregion
            #region ArrayList Kullanırken Boxing - Unboxing Durumları
            //ArrayList, verilen datayı boxing işlemine tabi tutar.
            //ArrayList içerisindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir. Dolayısıyla kendi türünde işlem yapabilmek için unboxing işlemine tabi tutmamız gerekir.
            //Koleksiyonlarda dizinin eleman sayısını getirirken count kullanmamız gerekir. Length propetysi dizilerde kullanılır

            int toplam = 0;
            for (int i = 0; i < _yaslar.Count; i++)
            {
                if (_yaslar[i] is int)
                {
                    toplam += (int)_yaslar[i];
                }
            }
            #endregion
            #region ArrayList Collection Initializers(Koleksiyon İlklendirici) İle Değer Ekleme
            ArrayList arrayList = new ArrayList()
            {
                "Emre",
                21,
                'e',
                true
            };
            #endregion
        }
    }
}
