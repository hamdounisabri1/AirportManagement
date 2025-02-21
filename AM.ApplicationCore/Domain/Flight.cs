using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        public Plane Plane { get; set; }

        public ICollection<Passenger> Passengers { get; set; }

        //public Flight(string destination, string departure, int flightId, DateTime flightDate, DateTime effectiveArrival, int estimatedDuration, Plane plane)
        //{
        //    Destination = destination;
        //    Departure = departure;
        //    FlightId = flightId;
        //    FlightDate = flightDate;
        //    EffectiveArrival = effectiveArrival;
        //    EstimatedDuration = estimatedDuration;
        //    Plane = plane;
        //}

        public override string? ToString()
        {
            return "FlightId: " + FlightId+ " Destination: " + Destination + " Departure: " + Departure + " FlightDate: "+ FlightDate + " EffectiveArrival: "+ EffectiveArrival + " EstimatedDuration: "+ EstimatedDuration;
        }
    }
}
