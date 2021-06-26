using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent
{
    class Rentable
    {
        //sioje klaseje apibreziama, kaip turi atrodyti vienas dalykas (objektas) Sablonas


        public bool Available { get; set; }
        public int Beds { get; set; }
        public bool Kitchen { get; set; }
        public bool Shower { get; set; }
        public int Floor { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }



    }
}
