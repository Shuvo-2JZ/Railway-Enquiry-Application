using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface ILoginRepository
    {
        bool UserLoginValidation(RLogin l);
    }
}
