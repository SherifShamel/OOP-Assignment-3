using OOP___Assignment03.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Assignment03.Classes
{
    internal class VIPTicket : Ticket, IPrintTicket
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

        public void PrintTicket()
        {
            Console.WriteLine($"Ticket: ${TicketId}, MovieName: ${MovieName}, Price: ${Price}, Price After Tax: ${PriceAfterTax()}, Lounge Access: ${LoungeAccess}, Service Fee: ${ServiceFee}");
        }

        public override object Clone()
        {
            ServiceFee = 0;
            return new VIPTicket(LoungeAccess, MovieName, Price);
        }
    }
}
