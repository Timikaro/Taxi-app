using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Taxi
    {
        public string NameDriver { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", NameDriver);

            if (OnDuty == true) { 
            Console.WriteLine("OnDuty : yes");
            }else
            {
                Console.WriteLine("OnDuty : no");
            }
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            }


        public void PickUpPassenger()
        {
            Console.WriteLine(NameDriver + " sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine(NameDriver + " selesai mengantar penumpang");
        }
    }
}
