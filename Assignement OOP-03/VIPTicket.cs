using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_OOP_03
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee = 50;

        public VIPTicket(bool loungeAccess, string moiveName ,decimal price): base(moiveName ,price)
        {
            LoungeAccess  = loungeAccess;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Lounge Access: {LoungeAccess} | Service Fee: {ServiceFee:0.00} EGP";
        }

       
    }
}
