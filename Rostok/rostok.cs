using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rostok
{
    class Rost
    {
        public string Név { get; set; }
        public string Kategória { get; set; }
        public string Egység { get; set; }
        public double rost { get; set; }

        public Rost(string sor)
        {
            string[] s = sor.Split(';');
            Név = s[0];
            Kategória = s[1];
            Egység = s[2];
            rost = double.Parse(s[3]);
        }
    }
}
