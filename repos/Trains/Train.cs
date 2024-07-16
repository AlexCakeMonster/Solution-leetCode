using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    struct Train
    {
        public int trainNumber;
        public string nameOfDestination;
        public DateTime departureTime;

        public Train(int trainNumber, string nameOfDestination, DateTime departureTime)
        {
            this.trainNumber = trainNumber;
            this.nameOfDestination = nameOfDestination;
            this.departureTime = departureTime;
        }


    }
}
