using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new BadPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new ExcelentPupil();

            ClassRoom classRoom = new ClassRoom(pupil1, pupil2);
            ClassRoom classRoom1 = new ClassRoom(pupil1, pupil2, pupil3);
            classRoom.ShowClass();
            classRoom1.ShowClass();

            Console.ReadKey();
        }
    }
}
