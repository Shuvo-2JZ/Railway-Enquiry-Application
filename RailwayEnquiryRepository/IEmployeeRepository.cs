using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface IEmployeeRepository
    {
        bool EmployeeAdd(REmployee e);
        bool EmployeeDelete(string id);
        bool PasswordChange(REmployee e);
        REmployee Profile(string id);
    }
}
