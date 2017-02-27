using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hesap makinasına hoşgeldiniz .");

            tekrar:

            sayi1tekrar :                                                     //1.sayının işlemleri buradan başlar
            Console.Write("1.sayı = ");
            int sayi1;
            if (int.TryParse(Console.ReadLine(), out sayi1))                 // sayının doğru girilmesi durumunda devam eder
            {
                
            }
            else                                                            // sayının yanlış girilirse tekrar ister
            { 
                Console.WriteLine("Sayısal bir değer girmelisiniz!"); 
                goto sayi1tekrar;
                Console.Write("1.sayı = ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("işlem giriniz(+,-,*,/) = ");                          // işlem giriş bölümü
            string inputi = Console.ReadLine();


            sayi2tekrar:                                                        // 2. sayının işlemleri buradan başlar
            Console.Write("2.sayı = ");
            int sayi2;
            if (int.TryParse(Console.ReadLine(), out sayi2))                    // sayının doğru girilmesi durumunda devam eder
            {

            }
            else                                                                // sayının yanlış girilirse tekrar ister
            {
                Console.WriteLine("Sayısal bir değer girmelisiniz!");
                goto sayi2tekrar;
                Console.Write("2.sayı = ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                

            }


            islem islemyap = new islem();                   // islem class'ını kullanmak birleştirdik.

            if (inputi == "*" )                             //class dan çağırılan işlemler 
            {
                int sonucu = islemyap.crpm(sayi1, sayi2);
                Console.WriteLine("Sonuç =" + sonucu);
            }
             else if (inputi == "+")
            {
                int sonucu = islemyap.toplam(sayi1, sayi2);
                Console.WriteLine("Sonuç =" + sonucu);
            }
             else if (inputi == "-")
            {
                int sonucu = islemyap.cikarma(sayi1, sayi2);
                Console.WriteLine("sonuç = " + sonucu);
            }
             else if (inputi == "/")
            {
                double sonucu = islemyap.bolum(sayi1, sayi2);
                Console.WriteLine("sonuç = " + sonucu);

            }

            else
                Console.WriteLine("Normal bir işlem giriniz işlem tipiniz HATALI"); // işlem tipi hatalı girilirse


            yanlistek:
            Console.Write("Devam etmek istiyormusunuz(E / H)");   
            String cikis = Console.ReadLine();
            if (cikis == "E")                           // Devam edilip edilmeyeceği ile ilgili kodlar
            {
                goto tekrar;
            }
            else if (cikis == "H")
            {
                Console.WriteLine("çıkmak için enter ' a basın");
            }
            else
            {
                Console.WriteLine("yanlış bir işlem girdiniz Devam etmek için 'E' çıkmak için 'H' giriniz.");
                goto yanlistek;
            }
            



        }
    }
}
