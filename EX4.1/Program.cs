using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EX4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci("2023001", "Ali", "Veli", 80, 85, 90, "XYZ Üniversitesi");
            Ogrenci ogrenci2 = new Ogrenci("2023002", "Ayşe", "Fatma", 75, 80, 70, "XYZ Üniversitesi");

            ogrenci1.OgrenciBilgileriGoster();
            Console.WriteLine("Ortalama: " + ogrenci1.ogrenciOrtalamasıBul());
            Console.WriteLine();


            ogrenci2.OgrenciBilgileriGoster();
            Console.WriteLine("Ortalama: " + ogrenci2.ogrenciOrtalamasıBul());
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
