using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketKiosk
{
    class Ticket
    {
        public string name;
        public int price;

        public Ticket()
        {
            name = string.Empty;
            price = 0;
        }

        public Ticket(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
