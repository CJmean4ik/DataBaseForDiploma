using CreateDbForDiplom.Entityes.RouteAndFlight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDbForDiplom.Entityes
{
    internal class Ticket
    {
        public int NumberTicket { get; set; }
        public decimal Price { get; set; }
        public DateTime DataSales { get; set; }

        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public List<Orders> Orders { get; set; }

    }
}
