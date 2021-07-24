using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
    class Building
    {
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public string _designer = "Gab";
        public DateTime _dateConstructed;
        public string _address;
        public string _owner;

        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }
    }
}
