using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._2TCKontrolUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TCKimlik tc1 = new TCKimlik();
            tc1.TCNo = "1234567890A"; // Geçersiz TC No
            Console.WriteLine("TC No: " + tc1.TCNo);
            TCKimlik tc2 = new TCKimlik();
            tc2.TCNo = "12345678901"; // Geçerli TC No
            Console.WriteLine("TC No: " + tc2.TCNo);
            Console.ReadLine();
        }
    }
}
