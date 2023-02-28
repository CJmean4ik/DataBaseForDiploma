using CreateDbForDiplom.Entityes.AIRLINEPLANES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDbForDiplom.Entityes.RouteAndFlight
{
    internal class Flight
    {
        public int NumberFlight { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int AirlinePlaneId { get; set; }
        public AirlinePlane AirlinePlane { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
