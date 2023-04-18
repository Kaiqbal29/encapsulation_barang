using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace encapsulation
{
    class Barang
    {
        public static int TotalBarang = 0;
        private string name;
        private int price;

        public Barang(string name, int price)
        {
            this.name = name;
            this.price = price;
            TotalBarang++;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
