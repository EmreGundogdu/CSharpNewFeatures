using System;

namespace TypeConversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Metinsel İfadelerin Diğer İfadelere Dönüştürülmesi            
            #region Parse Metodu
            //string türündeki değişkenlerin değerini hedef türe dönüştürür.

            string no = "12345";
            int.Parse(no);
            Console.WriteLine(no);

            string x = "123";
            short x2 = short.Parse(x);
            Console.WriteLine(x2 * 5);

            //2. Örnek -  TÜR HATASI
            //string a = "Emre";
            //int a2 = int.Parse(a);
            //Console.WriteLine(a2);

            //3. Örnek
            string medeniHal = "true";
            bool medeniHal2 = bool.Parse(medeniHal);
            Console.WriteLine(medeniHal2);

            //4. Örnek
            string c = "b";
            char c2 = char.Parse(c);
            Console.WriteLine(c2);
            #endregion
            #region Convert Metodu
            //her türü birbirine çeviren
            string v = "32131";
            Convert.ToInt32(v);

            string b = "3,14";
            double b2 = Convert.ToDouble(b);
            Console.WriteLine(b2 * 5 + "stringten doubleye dönüşüm");

            int a = 25;
            string a2 = Convert.ToString(a);
            Console.WriteLine(a2 + "intten strinde dönüşüm");

            double t5 = 3.16;
            string t6 = Convert.ToString(t5);
            Console.WriteLine(t6 + "");
            #endregion
            #region ToString Metodu
            float f = 35;
            string f2 = f.ToString();
            Console.WriteLine(f2 + "Floattan string dönüşüm");
            #endregion
            #region Bilinçsiz Tür Dönüşümü
            //byttan inte verir dönüştürürken yani küçükten büyüğe veri dönüştürürken olur mantık böyle
            int z = 3000;
            float z2 = z; //Şuanda bir tür dönüşümü söz konusudur.
            //Bir sayısal türün kendisinden daha geniş aralıkta bir başka sayısal türe atanması bilinçsiz tür dönüşümüdür.
            short l = 123;
            long k = l;
            #endregion
            #region Bilinçli Tür Dönüşümü
            //büyükten küçüğe veri türü değiştirirken ekstradan bi uğraş gerektireceği için buna bilinçli denir.
            int h = 3000;
            byte j = (byte)h;
            Console.WriteLine(j);
            #endregion
            #region checked 
            checked
            {
                //Bilinçli tür dönüşümü esnasında bir veri kaybı söz konusu olursa eğer runtime'da bizi uyarıcak bir kontrol mekanizmasıdır
                int t = 500;
                byte u = (byte)t;
                Console.WriteLine(u);
            }
            #endregion
            #region unchecked
            //  normal bir kod bloğu default olarak unchecked idir.
            unchecked
            {
                int o = 500;
                byte o2 = (byte)o;
                Console.WriteLine(o2);
            }
            #endregion
            #region bool sayısala dönüştürme
            bool q = true;
            short w = Convert.ToInt16(q); //1 değeri gelir true olduğu için - false olsaydı 0 sonucu olurdu
            Console.WriteLine(q);
            //  mantıksal değeri herhangi bir sayısal değere convert edersek ilgili değerin sayısal değeri verilir
            #endregion
            #region Sayısal türün bool türüne dönüştürülmesi
            int i = 132; //0 değeri yazılmadığı sürece bütün değerler true'dur. Bu bir istisnadır. Normalde 1 = true | 0 = false olması gerekir. Geri kalanının mümkün olmaması gerekir
            //yani 0 harici diğer tüm değerlerin true olması istisnadır
            bool i2 = Convert.ToBoolean(i);
            Console.WriteLine(i2);
            #endregion
            #region Char Türünün Sayısala Dönüştürülmesi
            char e = 'a';
            int _e = (int)e;
            Console.WriteLine(_e);
            #endregion
            #region Sayısal Türlerin Char Türüne Dönüştürülmesi
            int p = 111;
            int p2 = 53; //karşılığı olan asci karakterini bize verir
            Console.WriteLine((char)p);
            Console.WriteLine((char)p2);
            #endregion
        }
    }
}
