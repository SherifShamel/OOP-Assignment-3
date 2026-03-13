using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Assignment03.Classes
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee = 50;

        public VIPTicket(bool loungeAccess, string movieName, decimal price) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            if (LoungeAccess)
                Price += ServiceFee;
        }

        public override string ToString()
        {
            return $"Movie Name: {MovieName}\nSub Total: {Price - ServiceFee}\nTicket Id: {TicketId}\nLounge Access: {(LoungeAccess ? "Yes" : "No")}\nService Fee: {ServiceFee}\nTotal: {Price}";
        }

        public override void PrintTicket()
        {
            Console.WriteLine($"Ticket: ${TicketId}, MovieName: ${MovieName}, Price: ${Price}, Price After Tax: ${PriceAfterTax()}, Lounge Access: ${LoungeAccess}, Service Fee: ${ServiceFee}");
        }
    }
}
