using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_OOP_03
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D {  get; set; }

        public IMAXTicket (bool is3D ,string moiveName , decimal price): base (moiveName, price)
        {
            Is3D = is3D;
        }

        public override string ToString()
        {
            return base.ToString()+ $"| 3D: {Is3D}";
        }

    }
}
