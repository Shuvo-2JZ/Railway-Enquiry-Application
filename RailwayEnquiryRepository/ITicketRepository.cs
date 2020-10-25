using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface ITicketRepository
    {
        bool TicketSell(RTicket t);
        bool CancelReservation(string ticketid);
        List<RTicket> GetAllTicket();
        List<Seat> GetAllPrice();
    }
}
