using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delege
{
    // Delegeler sırasıyla metodları tetikleyen yapılardır.
    delegate void MyDelegate(int sayi1, int sayi2);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Topla); // Delegeye toplama metodunu ekledik.
            myDelegate += Carp; // Delegeye çarpma metodunu ekledik.
            myDelegate.Invoke(3, 5); // Delegeyi başlattık.
        }

        static void Topla(int numara1, int numara2)
        {
            Console.WriteLine(numara1 + numara2);
        }

        static void Carp(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 * sayi2);
        }
    }
}
