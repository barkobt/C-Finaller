using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizinin elemanlarını kullanıcdan alma ve ekrana yazdırma
            Console.WriteLine("Kaç tane isim girmek istiyorsunuz?");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] isimler = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. ismi giriniz:", i + 1);
                isimler[i] = Console.ReadLine();
            }

            Console.WriteLine("Girdiğiniz isimler:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(isimler[i]);
            }

        }
    }
}
