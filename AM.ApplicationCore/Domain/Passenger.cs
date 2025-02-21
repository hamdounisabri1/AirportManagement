using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddresse { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }

        public ICollection<Flight> Flights { get; set; }



        public override string? ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " PassportNumber: " + PassportNumber + " BirthDate: " + BirthDate + " EmailAddresse: " + EmailAddresse + " TelNumber: " + TelNumber;
        }

         public bool ChechProfile( string name ,string lastname)
        {
            return this.FirstName == name && this.LastName == lastname;
        }
         public bool ChechProfile(string name, string lastname , string email)
        {
            return this.FirstName == name && this.LastName == lastname && this.EmailAddresse== email;
        }

        public virtual void PassengerType()
        {
            System.Console.WriteLine("I am a passenger");
        }
    }
}
