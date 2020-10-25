using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayEnquiryRepository
{
    interface ITrainRepository
    {
        bool TrainAdd(Train t);
        bool TrainUpdate(Train t);
        bool CancelSchedule(string trainid);
        Train TrainSearch(string trainid);
        List<Train> SearchTrain(string Text);
        List<Train> GetAllTrains();  
    }
}
