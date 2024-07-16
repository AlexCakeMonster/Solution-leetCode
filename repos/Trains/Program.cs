using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainSchedule trainSchedule = new TrainSchedule();
            trainSchedule[0] = trainSchedule.ReceivingInformationFromTheUser();
            trainSchedule[1] = trainSchedule.ReceivingInformationFromTheUser();
            //trainSchedule[2] = trainSchedule.ReceivingInformationFromTheUser();
            //trainSchedule[3] = trainSchedule.ReceivingInformationFromTheUser();

            trainSchedule.ShowTrainInformation();

            Console.ReadKey();
        }
    }
}
