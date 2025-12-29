using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.setIsim("Baran");
            Console.WriteLine("Öğrenci Adı: " + ogrenci1.getIsim());
            Console.ReadLine();


        }
    }
}
