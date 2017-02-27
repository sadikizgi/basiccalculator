using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class islem
    {
        public int toplam(int sayi1, int sayi2) //toplama işlemi
        {
            int topla = sayi1 + sayi2;
            return topla;

        }
        public int cikarma(int sayi1 , int sayi2 ) //çıkarma işlemi
        {
             int cikar = sayi1 - sayi2;
            return cikar;

        }
        public double bolum (int sayi1 , int sayi2) // bölme işlemi
        {
            int bol = sayi1 / sayi2;
            return Convert.ToDouble(bol);

        }
        public int crpm (int sayi1 , int sayi2) // çarpma işlemi
        {
            int crp = sayi1 * sayi2;
            return crp;

        }

    }
}
