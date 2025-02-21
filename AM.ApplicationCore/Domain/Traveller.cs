using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
            public String Nationality { get; set; }
            public String HealthInformation { get; set; }

        public override void PassengerType()
        {
            System.Console.WriteLine("I am a Traveller");
        }
    }
}
