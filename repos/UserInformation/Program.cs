using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Login = "3657";
            user1.Name = "Alex";
            user1.Surname = "Tugin";
            user1.Age = "28";

            Console.WriteLine(user1.UserInformation());
            Console.ReadKey();
        }
    }
}
