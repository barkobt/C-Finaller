using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4Property
{
    internal class Program
    {
        static void Main(string[] args)
        //GET ve SET kullanımı
        {
            Musteri musteri = new Musteri();
            musteri.KILO = 75; // set bloğu çalışır
            // Burada set bloğu ile kontrol sağlanır, 
            // örneğin kilo negatif olamaz gibi.
            // Eğer değer ataması olmasaya, set bloğu çalışmayacaktı.
            Console.WriteLine("Müşterinin Kilosu: " + musteri.KILO); // get bloğu çalışır
        }
    }
}
