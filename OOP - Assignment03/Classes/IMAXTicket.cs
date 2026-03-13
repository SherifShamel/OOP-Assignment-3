using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Assignment03.Classes
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }
        public IMAXTicket(bool is3rd, string movieName, decimal price) : base(movieName, price)
        {
            if (is3rd)
                Price += 30;
        }

        public override string ToString()
        {
            return $"Movie Name: {MovieName}\nPrice: {Price}\nTicket Id: {TicketId}\nTicketType: IMAX\nMovie Type: {(Is3D ? "3D" : "Normal")}";
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket: ${TicketId}, MovieName: ${MovieName}, Price: ${Price}, Price After Tax: ${PriceAfterTax()}, Film Type: ${(Is3D ? "3D" : "Standard")}");
        }
    }
}
