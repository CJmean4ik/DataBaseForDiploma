using CreateDbForDiplom.Entityes.RouteAndFlight;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDbForDiplom.Entityes.AIRLINEPLANES
{
    internal class AirlinePlane
    {
        public int ID { get; set; }
        public string SendingAirline { get; set; }      
        public int AirLineId { get; set; }
        public AirLine AirLine { get; set; }


        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        public bool InRaise { get; set; }

        public List<Flight> Flights { get; set; }
    }
}
