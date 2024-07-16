using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class BadPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Stady bad");
        public override void Read() => Console.WriteLine("Read bad");
        public override void Write() => Console.WriteLine("Write bad");
        public override void Relax() => Console.WriteLine("Relax bad");
    }
}
