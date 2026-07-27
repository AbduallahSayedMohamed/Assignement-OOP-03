using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_OOP_03
{
    internal static class BookingHelper
    {
        public static double CalcGroupDiscount(int numberOfTicket, double PricePerTicket)
        {
            double Total;
            if (numberOfTicket >= 5)
            {

                Total = numberOfTicket * (PricePerTicket - (PricePerTicket * 10 / 100));
            }
            else
            {
                Total = numberOfTicket * PricePerTicket;
            }
            return Total;
        }

        private static int Counter = 0;
        public static string GenerateBookingReference()
        {
            Counter++;
            return $" Booking Reference {Counter} : BK-{Counter}";

        }


    }
}
