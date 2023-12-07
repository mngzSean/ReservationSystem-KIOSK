using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketKiosk
{
    class TicketViewModel
    { 
        public string? Name
        {
            get
            {
                return _Ticket.name;
            }
            set
            {
                _Ticket.name = value!;
            }
        }
        public string? Price
        {
            get
            {
                return _Ticket.price.ToString("C");
            }
            set
            { }
        }
        public int? Count { get; set; } = 0;
        public string? Total
        {
            get
            {
                return (_Ticket.price * _Count).ToString("C");
            }
        }

        private Ticket _Ticket;
        private int _Count;

        public TicketViewModel()
        {
            _Ticket = new Ticket();
        }

        public TicketViewModel(Ticket Ticket) : this()
        {
            _Ticket = Ticket;
            _Count = 0;
        }
        public TicketViewModel(Ticket Ticket, int count) : this()
        {
            _Ticket = Ticket;
            _Count = count;
        }
    }
}
