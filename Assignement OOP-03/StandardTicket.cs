using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_OOP_03
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
       
        public StandardTicket(string seatNumber, string moiveName, decimal price) : base(moiveName, price) 
        {
            SeatNumber = seatNumber;
          
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {SeatNumber}";
        }
    }
}
