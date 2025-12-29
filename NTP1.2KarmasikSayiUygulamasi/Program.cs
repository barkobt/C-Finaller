using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmasikSayiUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(3, 4);
            Complex z2 = new Complex(1, 2);


            // Operatör aşırı yükleme kullanarak toplama
            Complex sonuc = z1 + z2;
            Complex sonuc2 = z1 + 10.5;
            Complex carpim = z1 * z2;
            Complex bolum = z1 / z2;


            Console.WriteLine("z1: " + z1);
            Console.WriteLine("z2: " + z2);
            Console.WriteLine("z1 + z2: " + sonuc);
            Console.WriteLine("z1 + 10.5: " + sonuc2);
            
            Console.WriteLine($"Z1 * Z2 = {carpim}"); // Beklenen: (4*3 - 2*-1) + (4*-1 + 2*3)i = 14 + 2i
            Console.WriteLine($"Z1 / Z2 = {bolum}");  // Beklenen: 1 + i (yaklaşık)
        }
    }
}
