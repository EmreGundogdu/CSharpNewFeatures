using System;
using System.Text.RegularExpressions;

namespace Düzenliİfadeler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Regular Expressions Operators
            //^ Operatörü : Satır başının istenilen ifadeyle başlamasını sağlar.
            //^9 : 99dasdas, 9dsada, 9-*-/2132 ||| dsa999, *-*-**9,
            string text = "9414857312218763";
            Regex regex = new Regex("^9");
            Match match = regex.Match(text);
            Console.WriteLine(match.Success);
            #endregion
        }
    }
}
