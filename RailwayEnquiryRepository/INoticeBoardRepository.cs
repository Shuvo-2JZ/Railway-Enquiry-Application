using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface INoticeBoardRepository
    {
        bool NoticeAdd(Notice n);
        bool NoticeDelete(string noticeid);
        List<Notice> GetAllNotice();
    }
}
