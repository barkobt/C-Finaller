using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EkranaYazdir("Merhaba Dünya!");
            ToplaVeYazdir(5, 10);
            ParametresizMetot();


            int sonuc = Topla(7, 3);
            Console.WriteLine("Topla metodu sonucu: " + sonuc);
            string mesaj = MesajOlustur("Baran");
            Console.WriteLine(mesaj);
        }

        // Geri dönüş tipi olmayan metotlar
        static void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        static void ToplaVeYazdir(int a, int b)
        {
            int toplam = a + b;
            Console.WriteLine("Toplam: " + toplam);
        }

        static void ParametresizMetot()
        {
            Console.WriteLine("Bu metot parametresizdir.");
        }

        // Geri dönüş tipi olan metotlar
        static int Topla(int a, int b)
        {
            return a + b;
        }

        static string MesajOlustur(string isim)
        {
            return "Merhaba, " + isim + "!";
        }

    }
}
