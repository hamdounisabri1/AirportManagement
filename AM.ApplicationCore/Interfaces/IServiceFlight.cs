using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {

        public List<DateTime> GetFlights ( string destinations);
        public void GetFlights(string filterType ,string filterValue);

         public void ShowFlightDetails(Plane plane);

        public int ProgrammedFlightNumber(DateTime startDate);


        public double DurationAverage(String Destinantion);

        public List<Flight> test();


        public IEnumerable<Traveller> SeniorTravller(Flight f);
        public IEnumerable<IGrouping<String , Flight>> DestinationGroupedFlights();
    }
}
