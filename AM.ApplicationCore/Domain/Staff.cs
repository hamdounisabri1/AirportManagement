using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentTime { get; set; } 
        public string Function { get; set; }    
        public float Salary { get; set; }

       
        
        public override void  PassengerType()
        {
            System.Console.WriteLine("I am a Staff");
        }
    }
}
