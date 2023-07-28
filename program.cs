using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Emt Mağazamızı Hoş Geldiniz ^_^ ");
            double urun_fiyati, kargo, toplam;
            Console.Write("Lütfen Ürün Fiyatını Giriniz : ");
            urun_fiyati = double.Parse(Console.ReadLine());

            if (urun_fiyati >= 100)

            {
                Console.WriteLine("Kargonuz Ücretsiz Olacaktır.");
            }

            else if (urun_fiyati < 100)

            {
                kargo  = 5;
                toplam = urun_fiyati + kargo;
                Console.WriteLine("Kargoya  5'Tl Fazla Alınacaktır " + ":" + toplam );
            }

            Console.ReadKey();
        }
    }
}
        