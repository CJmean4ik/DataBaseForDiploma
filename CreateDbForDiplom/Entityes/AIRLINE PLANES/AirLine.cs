using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDbForDiplom.Entityes.AIRLINEPLANES
{
    internal class AirLine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }

        public List<AirlinePlane> AirlinePlanes { get; set; }
    }
}
