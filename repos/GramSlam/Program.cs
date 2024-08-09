using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GramSlam
{
    class Program
    {
        static void Main(string[] args)
        {
          using(GrandSlamDBEntities gb = new GrandSlamDBEntities())
            {
                var player = from p in gb.PlayerInfos
                             where p.Player.LName == "Murray"
                             select new { p.PlayerId, p.Residence, p.Height };

                foreach (var item in player)
                {
                    Console.WriteLine($"PlayerId: {item.PlayerId}, p.Residence : {item.Residence}");
                }

                var player1 = gb.PlayerInfos.Where(p => p.Height > 190).Select(p => new { p.PlayerId });

                foreach (var item in player1)
                {
                    Console.WriteLine($"PlayerId: {item.PlayerId}");
                }
                Console.ReadKey();
            }
        }
    }
}
