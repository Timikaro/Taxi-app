using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi1 = new Taxi();

            taxi1.NameDriver = "Jono";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 10;

            taxi1.TaxiInfo();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
