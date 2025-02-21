using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {

        public List<Flight> flights {  get; set; } = new List<Flight>();
        public List<Passenger> passengers { get; set; } = new List<Passenger>();


        //public List<DateTime> GetFlights(string destinations)
        //{
        //   List<DateTime> list = new List<DateTime>();
        //    for (int i = 0; i < flights.Count; i++) { 
        //       if(flights[i].Destination == destinations) { list.Add(flights[i].FlightDate); }
        //    }
        //    return list;
        //}

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in flights) { if (flight.Destination == filterValue) { Console.WriteLine(flight.ToString()); } }
                    break;
                case "FlightDate":
                    foreach (var flight in flights) { if (flight.FlightDate.ToString().Equals(filterValue)) { Console.WriteLine(flight.ToString()); } }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in flights) { if (flight.EffectiveArrival.ToString().Equals(filterValue)) { Console.WriteLine(flight.ToString()); } }
                    break;
                default:
                    break;

            }

        }




        public List<DateTime> GetFlights(string des)
        {
            return flights.Where(f => f.Destination == des).Select(f => f.FlightDate).ToList();
        }
        public List<DateTime> GetFlightDates(string destination)
        {
            var query = from flight in flights
                        where flight.Destination == destination
                        select flight.FlightDate;

            return query.ToList();
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from flight in flights
                        where flight.Plane == plane
                        select new { flight.FlightDate, flight.Destination };
            var query2 = flights.Where(f => f.Plane == plane).Select(f => new {f.FlightDate , f.Destination});

            foreach (var flightDetail in query)
            {
                Console.WriteLine($" Date: {flightDetail.FlightDate}, Destination: {flightDetail.Destination}");
            }
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = from flight in flights
                        where DateTime.Compare(flight.FlightDate, startDate) >= 0
                              && (flight.FlightDate - startDate).TotalDays <= 7
                        select flight; 

            return query.Count();
        }

        public double DurationAverage(string Destinantion)
        {
            var query = from flight in flights
                        where (flight.Destination == Destinantion)
                        select flight.EstimatedDuration ;
            var q2 = flights.Where(f => f.Destination == Destinantion).Select(f => f.EstimatedDuration);

            return query.Average();
        }

  

        public List<Flight> test()
        {
            var q = from flight in flights
                    orderby flight.EstimatedDuration descending
                    select flight;

            var q1 = flights.OrderByDescending(f => f.EstimatedDuration);

            return q.ToList();
        }

        public IEnumerable<Traveller> SeniorTravller(Flight f)
        {
            var q = from traveller in f.Passengers.OfType<Traveller>()
                    orderby traveller.BirthDate
                    select traveller;

            var q2 = f.Passengers.OfType<Traveller>().OrderBy(t => t.BirthDate).Take(3);

            return q.Take(3);
        }

        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights()
        {
            var q = from flight in flights
                    group flight by flight.Destination;
            foreach (var f in q) {

            Console.WriteLine(f.Key);
                foreach (var flight in f) {
                    Console.WriteLine(flight.FlightDate);

                }

            } 
            return q;

        }
    }
}
