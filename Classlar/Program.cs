using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Araba araba1 = new Araba(4,"Kırmızı","Renault");
            /*
            araba1.kapiSayisi = 4;
            araba1.arabaRenk = "Kırmızı";
            araba1.arabaModel = "Toyota Corolla";
            */

            Console.WriteLine("Araba 1 Model: " + araba1.arabaModel);
            Console.WriteLine("Araba 1 Renk: " + araba1.arabaRenk);
            Console.WriteLine("Araba 1 Kapı Sayısı: " + araba1.kapiSayisi);
            araba1.motorCalistir();
            araba1.kapilariKilitle();

            Araba araba2 = new Araba(2,"Mavi","Ford Mustang");
            /*
            araba2.kapiSayisi = 2;
            araba2.arabaRenk = "Mavi";
            araba2.arabaModel = "Ford Mustang";
            */Mod


            Console.WriteLine();
            Console.WriteLine("Araba 2 Model: " + araba2.arabaModel);
            Console.WriteLine("Araba 2 Renk: " + araba2.arabaRenk);
            Console.WriteLine("Araba 2 Kapı Sayısı: " + araba2.kapiSayisi);
            araba2.motorCalistir();
            araba2.kapilariKilitle();
            Console.ReadLine();
        }
    }
}
