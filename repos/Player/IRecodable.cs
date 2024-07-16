using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
