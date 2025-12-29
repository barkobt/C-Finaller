using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifreOlusturucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan isim ve soyisim al
            Console.Write("İsminizi girin: ");
            string isim = Console.ReadLine();
            Console.Write("Soyisminizi girin: ");
            string soyisim = Console.ReadLine();

            char[] ozel_karakterler = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+' };

            // Rastgele karakter seçimi için Random nesnesi oluştur
            Random random = new Random();
            // İlk isimden rastgele 4 karakter seç
            string sifre = "";
            for (int i = 0; i < 4; i++)
            {
                int ind = random.Next(isim.Length);
                sifre += isim.Substring(ind, 1);
            }
            sifre += ozel_karakterler[random.Next(ozel_karakterler.Length)];


            // Soyisimden rastgele 5 karakter seç
            for (int i = 0; i < 5; i++)
            {
                int ind = random.Next(soyisim.Length);
                sifre += soyisim.Substring(ind, 1);
            }
            // Oluşturulan şifreyi ekrana yazdır
            Console.WriteLine($"Oluşturulan Şifre: {sifre}");

        }
    }
}
