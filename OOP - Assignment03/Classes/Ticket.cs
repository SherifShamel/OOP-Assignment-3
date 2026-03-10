using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Assignment03.Classes
{
    internal class Ticket
    {
        public string MovieName { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price must be positive");
                    return;
                }
            }
        }
        static public int TicketId { get; private set; }

        public Ticket(string movieName, decimal price)
        {
            TicketId++;
            MovieName = movieName;
            Price = price;
            
        }

        public decimal PriceAfterTax()
        {
            Price = (Price * (14 / 100)) + Price;
            return Price;
        }

        public override string ToString()
        {
            return $"Movie Name: {MovieName}\nPrice: {Price}\nTicket Id: {TicketId}";
        }

        static int GetTotalTickets()
        {
            return TicketId;
        }
    }
}
