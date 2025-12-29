using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Metin_Isleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Jonathan Goldman"; //
            int pos = myName.IndexOf(" ");      // Boşluğun yerini bulur

            // Alt Dizgiler (Substrings)
            string snc1 = myName.Substring(0, 1) + ". " + myName.Substring(pos + 1); // J. Goldman
            string snc2 = myName.Substring(0, pos) + ". " + myName.Substring(pos + 1, 1); // Jonathan. G

            // Rastgele Karakter Seçimi
            string snc5 = "";
            Random random = new Random();
            string[] part = myName.Split(' '); // İsmi parçalara böler: ["Jonathan", "Goldman"]

            // İlk isimden rastgele 4 karakter
            for (int i = 0; i < 4; i++)
            {
                int ind = random.Next(part[0].Length);
                snc5 += part[0].Substring(ind, 1);
            }
            snc5 += ".";
            // Soyisimden rastgele 5 karakter
            for (int i = 0; i < 5; i++)
            {
                int ind = random.Next(part[1].Length);
                snc5 += part[1].Substring(ind, 1);
            }
            Console.WriteLine($"Üretilen Kod: {snc5}");
        }
    }
}
