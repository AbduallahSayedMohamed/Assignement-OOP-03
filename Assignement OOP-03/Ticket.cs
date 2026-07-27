using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_OOP_03
{
    internal class Ticket
    {
        public  string? _MovieName { get; set; }
        private  decimal _Price ;
        public int TicketId { get; set; }
        public static int TotalTickets = 0;
        
        public Ticket (string MoiveName , decimal Price)
        {
            TotalTickets++;
            TicketId = TotalTickets; 
            _MovieName = MoiveName;
            _Price = Price;
        }

        public decimal Price
        {
            get { return _Price; }
            set
            {
                if (value > 0)
                    _Price = value;
            }
        }

        public decimal PriceAfterTax
        {
            get { return _Price + (_Price * 14 / 100); }
  
        }
        public  override string ToString()
        {
            return $" MovieName  : {_MovieName}| Price: {_Price} | After tax {PriceAfterTax}";
        }
        public static int GetTotalTickets()
        {
            return TotalTickets;
        }
    }
}
