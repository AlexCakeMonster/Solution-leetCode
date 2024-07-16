using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trains
{
    class TrainSchedule
    {
        Train[] trains = new Train[0];

        public Train this[int index]
        {
            set
            {
                if(trains.Length - 1 >= index && index >= 0)
                {
                    trains[index] = value; 
                }
                else
                {
                    Array.Resize(ref trains, trains.Length + 1);
                    trains[trains.Length - 1] = value;
                }
            }
        }
        //ReceivingInformationFromTheUser
        /// <summary>
        /// Receiving information from users and creating a train card
        /// </summary>
        /// <returns></returns>
        public Train ReceivingInformationFromTheUser()
        {
            Console.Write("Введите номер поезда: ");
            int trainNumber;
            trainNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введите пункт назначение поезда № {trainNumber}: ");
            string nameOfDestination;
            nameOfDestination = Console.ReadLine();

            Console.Write($"Введите дату и время прибытия № {trainNumber} в формате дд/мм/гггг ч:мм : ");
            DateTime departureTime;
            departureTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Поезд успешно добавлен.\n" + new String('_', 10));

            return InstantiationTrain(trainNumber,nameOfDestination,departureTime);           
        }

        private Train InstantiationTrain(int trainNumber, string nameOfDestination, DateTime departureTime)
        {
            Train train = new Train(trainNumber, nameOfDestination, departureTime);
            return train;
        }

        /// <summary>
        /// Search and display information about the train by number entered by the user
        /// </summary>
        public void ShowTrainInformation()
        {
            Console.Write("Введите номер поезда для получения информации: ");
            int trainNumber;
            trainNumber = Convert.ToInt32(Console.ReadLine());

            bool trainFound = false;

            foreach (Train element in trains)
            {
                if(element.trainNumber == trainNumber)
                {
                    Console.WriteLine($"Поезд № {element.trainNumber} следующий в {element.nameOfDestination} прибудет в {element.departureTime}");
                    trainFound = true;
                }
            }

            if (!trainFound)
            {
                Console.WriteLine($"Поезд № {trainNumber} не найден.");
            }
        }
    }
}
