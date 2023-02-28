using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDbForDiplom.Entityes.RouteAndFlight
{
    internal class Route
    {
        public int ID { get; set; }
        public string FromWhere { get; set; }
        public string Where { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Incoming { get; set; }

        public List<Flight> Flights { get; set; }

    }
}
