using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface ISeatRepository
    {
        bool SeatAdd(Seat s);
        bool SeatDelete(string seatid);
        List<Seat> GetAllSeats();
    }
}
