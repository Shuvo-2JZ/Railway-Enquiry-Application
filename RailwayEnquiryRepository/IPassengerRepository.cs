using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface IPassengerRepository
    {
        bool PassengerAdd(RPassenger p);
        bool PassengerDelete(string id);
        RPassenger Profile(string id);
        bool PasswordChange(RPassenger p);
        List<RTicket> GetPassengerTicket(string id);
        List<RPassenger> GetAllPassengers();
        List<RPassenger> SearchPassenger(string text);
    }
}
