using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class GoodPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Stady good");
        public override void Read() => Console.WriteLine("Read good");
        public override void Write() => Console.WriteLine("Write good");
        public override void Relax() => Console.WriteLine("Relax good");
    }
}
