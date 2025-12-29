using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] sayilar = new int[4];

            sayilar[0] = 10;
            sayilar[1] = 20; 
            sayilar[2] = 30;
            sayilar[3] = 40;

            for(int i = 0; i<sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();

            */

            //string
            //double
            //char

            string[] isimler = {"Enes", "Yasin", "Mehmet", "Ercan", "Kasım"};

            double[] ondalikli_sayilar = { 10.5, 20.3, 30.6, 40.2 };

            char[] karakterler = { 'A', 'B', 'C', 'D', 'E' };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            Console.WriteLine("Bir tuşa basın:");
            Console.ReadLine();

            for (int i = 0; i < ondalikli_sayilar.Length; i++)
            {
                Console.WriteLine(ondalikli_sayilar[i]);
            }

            Console.WriteLine("Bir tuşa basın:");
            Console.ReadLine();

            for (int i = 0; i < karakterler.Length; i++)
            {
                Console.WriteLine(karakterler[i]);
            }
        }
    }
}
