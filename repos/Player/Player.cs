using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Player : IRecodable, IPlayable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("Record pause");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Play pause");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Play");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Record");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record stop");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Play stop");
        }
    }
}
