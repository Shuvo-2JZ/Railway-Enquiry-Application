using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface IAdminRepository
    {
        bool AdminAdd(RAdmin a);
        bool PasswordChange(RAdmin a);
        RAdmin Profile(string id);

    }
}
