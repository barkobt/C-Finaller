using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GeometriUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Nokta Pratiği
            Nokta n1 = new Nokta(5, 12);
            Nokta n2 = new Nokta(25, 5); // Property sayesinde x=20 olacak
            Console.WriteLine("--- NOKTALAR ---");
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            // 2. Doğru Parçası Pratiği
            DogruParcasi d1 = new DogruParcasi(n1, n2);
            Console.WriteLine("\n--- DOĞRU PARÇASI ---");
            Console.WriteLine(d1);

            // 3. Dikdörtgen Pratiği
            Rectangle r1 = new Rectangle(3, 4);
            Console.WriteLine("\n--- DİKDÖRTGEN ---");
            Console.WriteLine(r1);

            Console.ReadLine(); // Ekranın hemen kapanmaması için
        }
    }
}
