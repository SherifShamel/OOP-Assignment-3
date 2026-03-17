using OOP___Assignment03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Assignment03.Classes
{
    internal class StandardTicket : Ticket, IPrintTicket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string seatNumber, string movieName, decimal price) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return $"Movie Name: {MovieName}\nPrice: {Price}\nTicket Id: {TicketId}\nSeat Number: {SeatNumber}";
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Ticket: ${TicketId}, MovieName: ${MovieName}, Price: ${Price}, Price After Tax: ${PriceAfterTax()}, Seat Number: ${SeatNumber}");
        }

        public override object Clone()
        {
            return new StandardTicket(SeatNumber, MovieName, Price);
        }

    }
}
