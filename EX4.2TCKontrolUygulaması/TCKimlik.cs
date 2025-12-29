using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._2TCKontrolUygulaması
{
    public class TCKimlik
    {
        private string tcNo;
        public string TCNo
        {
            get
            {
                return tcNo;
            }
            set
            {
                if ((value.Length != 11) || ((value.All(char.IsDigit)) == false)) {
                    tcNo = "00000000000";
                    Console.WriteLine("TC No'nuz 11 basamaklı sayılardan oluşmalıdır.");
                }
                else
                    tcNo = value;
            }
        }
    }
}
