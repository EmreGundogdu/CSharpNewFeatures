using System;

namespace Sabitler
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir const tanımlandığında STACK'te ilgili türde alan tahsis edilecektir ve ilk atanan değer dışında bir daha değer kabule etmeyecektir.
            //const değerleri tanımlama aşamasında değer bekler
            const double pi = 3.14;
            #region Global Değişkenler
            //Global : bir değişken class scopeu içinde tanımlanıyorsa buna global değişken denir.
            //Lokal : Metod içerisinde tanımlanan değişkenlerdir
            #endregion
            #region 1. Değişken Tanımlama Varyasyonu
            int a = 5;
            #endregion
            #region 2. Değişken Tanımlama Varyasyonu
            //aynı türden olan değişkenleri bu şekilde basit olarak yazabiliriz
            int b = 5, c = 10;
            #endregion
            #region Deep Copy
            int d = 5;
            int f = d;
            d = d * 5; //d'nin değer 5'ten 25e çıkar ve f nin değeri 5 olarak kalır. Derin kopyalama örneğidir.
            Console.WriteLine(d);
            Console.WriteLine(f);
            #endregion
            #region Shallow Copy

            #endregion
            #region OBJECT TÜRÜ - BOXING
            // Object : tüm türleri karşılayan bir türdür.
            // Object ile bir değişkenin değeri özünde kendi türüdür ve o türde STACK'te tutulur. 
            //Object ile bir değişkenin değerini oluşturmaya BOXING DENİR.
            //Object ile bir değişkenin değerini verisi kendi türünden elde etmeye UnBOXING DENİR.
            // string,int,bool,char = > Object
            #endregion
            #region Boxing
            int yas = 21;
            object _yas = 22; //boxing (bir değeri object türü altında atamaya boxing denir) yani bir int değeri object olarak türünü belirtmiş oluyoruz
            #endregion
            #region Cast Operatörü
            int z = 5;
            object y = z;
            Console.WriteLine((int)y * 5);//unboxing - objecti inte cast ederek unboxing yapmış olduk
            #endregion
            #region Var keywordu
            //var keywordu bi iken object ise bir türdür. Var atanan değerin türüne bürünür. Object atanan değeri boxing yaparak object türüne dönüştürür
            //var ile değişken tanımlarken değeri belirtmek zorunludur.
            #endregion
            #region dynamic keywordu
            dynamic x = 5;
            Console.WriteLine(x * 5); //proje çalıştığında sonuç int olucaksa bunu hesaplıcak ama x'in dğerini string vermiş olsaydık proje çalıştıktan sonra ata vericekti. 
            //Çünkü proje çalıştıktan sonra tipi string olucaktı ve int ile çarpımı mümkün olmuyacaktı
            //proje çalışana kadar bunun tipi dynamic olarak kalır 
            //dynamıc 
            #endregion
        }
    }
}
