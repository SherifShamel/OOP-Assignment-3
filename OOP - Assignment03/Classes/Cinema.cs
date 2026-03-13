using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Assignment03.Classes
{
    internal class Cinema
    {
        public Ticket Ticket { get; set; }
        public string CinemaName { get; set; }
        Projector Projector = new Projector();

        public void AddTicket(Ticket t)
        {
            Ticket = t;
        }

        public Cinema(Ticket t, string cinemaName)
        {
            Ticket = t;
            CinemaName = cinemaName;
        }
        public void PrintAllTickets()
        {
            Console.WriteLine(Ticket);
        }

        public void OpenCinema()
        {
            Projector.OpenCinema();
        }
        public void CloseCinema()
        {
            Projector.CloseCinema();
        }

        public static void ProcessTicket(Ticket t)
        {
            t.PrintTicket();
        }

    }
}
