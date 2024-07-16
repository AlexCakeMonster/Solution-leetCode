using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            playable.Play();
            playable.Pause();
            playable.Stop();
            IRecodable recodable = new Player();
            recodable.Record();
            recodable.Pause();
            recodable.Stop();

            Console.ReadKey();
        }
    }
}
