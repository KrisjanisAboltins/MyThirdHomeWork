using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThirdHomeWork
{
    public class ExcesizePhone
    {
        public double Size { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Call()
        {
            Console.WriteLine("Calling");
         }

        public void Sms()
        {
            Console.WriteLine("SMS sent");
        }


    }
}



