using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Merhaba");
            koleksiyon.Add(42);
            koleksiyon.Add(3.14);
            koleksiyon.Add(true);

            foreach (var item in koleksiyon)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            koleksiyon.Remove(42);

            Console.WriteLine("42 öğesi kaldırıldıktan sonra koleksiyon:");
            foreach (var item in koleksiyon)
            {
                Console.WriteLine(item);
            }

            int count = koleksiyon.Count;
            Console.WriteLine("Koleksiyondaki öğe sayısı: " + count);

            //koleksiyon.Clear();
            //Console.WriteLine("Koleksiyon temizlendikten sonra öğe sayısı: " + koleksiyon.Count);

            bool kontrol = koleksiyon.Contains("Merhaba");
            Console.WriteLine("Koleksiyon 'Merhaba' öğesini içeriyor mu? " + kontrol);


            koleksiyon.Insert(1, "Dünya");

            Console.WriteLine("Koleksiyon 'Dünya' öğesi eklendikten sonra:");
            foreach (var item in koleksiyon)
            {
                Console.WriteLine(item);
            }

            int index = koleksiyon.IndexOf("Merhaba");
            Console.WriteLine("'Merhaba' öğesinin indeksi: " + index);
            
            //koleksiyon.Sort(); // Hata verebilir çünkü farklı türler karşılaştırılamaz
            Console.ReadLine();




        }
    }
}
