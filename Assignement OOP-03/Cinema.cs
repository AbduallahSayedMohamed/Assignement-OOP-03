using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_OOP_03
{
    public class Projector
    {
        public void start()
        {
            Console.WriteLine(" Projector Started.");
        }

        public void stop()
        {
            Console.WriteLine(" Projector Stopped.");
        }
    }

    internal class Cinema
    {
        public string? _name { get; set; }
        public Projector _Projector;
        private Ticket[] Tickets;

        public Cinema(string name )
        {    
            _name = name;
            Tickets = new Ticket[20];
            _Projector = new Projector();
        }

        public Ticket? this[int index]
        {
            get
            {
                if (index >= 0 && index <= Tickets.Length)
                {
                    return Tickets[index];
                }
                return null;
            }
            set
            {
                if (index < 0 && index <= Tickets.Length)
                    Tickets[index] = value;
            }

        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < Tickets.Length; i++)
            {

                if (Tickets[i] == null)
                {
                    Tickets[i] = t;
                    return true;
                }
            }
                return false;
        }

        public void PrintAllTickets()
        {
            for (int i = 0; i < Tickets.Length; i++)
            {
                Console.WriteLine(Tickets[i]);
            }
        }
        public void OpenCinema()
        {
            _Projector.start();
        }

        public void CloseCinema()
        {
            _Projector.stop();
        }
    }
}
