using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        Pupil [] pupils = new Pupil[4];
        Random random = new Random();
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = PupilRandom();
            pupils[3] = PupilRandom();
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = PupilRandom();
        }

        private Pupil PupilRandom()
        {
            int ran = random.Next(1, 4);

            switch (ran)
            {
                case 1:
                    return new BadPupil();

                case 2:
                    return new GoodPupil();
                case 3:
                    return new ExcelentPupil();
                default:
                    return new BadPupil();
            }
        }

        public void ShowClass()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine(new String('_', 10) + $"\nStudent {i+1}");
                pupils[i].Read();
                pupils[i].Relax();
                pupils[i].Study();
                pupils[i].Read();
            }
        }
    }
}
