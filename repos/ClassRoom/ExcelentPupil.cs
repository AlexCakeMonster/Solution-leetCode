using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ExcelentPupil : Pupil 
    {
        public override void Study() => Console.WriteLine("Stady Excelent");
        public override void Read() => Console.WriteLine("Read Excelent");
        public override void Write() => Console.WriteLine("Write Excelent");
        public override void Relax() => Console.WriteLine("Relax Excelent");
    }
}
