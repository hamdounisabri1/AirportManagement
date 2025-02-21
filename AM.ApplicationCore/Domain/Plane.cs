using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {

        public int Capacity { get; set; } 
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public Ptype PlaneType { get; set; }
        ICollection<Flight>  Flights { get; set; }

        //public Plane(int capacity, DateTime manufactureDate, Ptype planeType)
        //{
        //    Capacity = capacity;
        //    ManufactureDate = manufactureDate;
        //    PlaneType = planeType;
        //}

        public override string? ToString()
        {
            return "PlaneId: " + PlaneId + " PlaneType: " + PlaneType + " Departure: " + ManufactureDate + " Capacity: " + Capacity ;
        }

    }
       public enum Ptype
        {
            BOEING,
            AIRBUS
        }
    }





