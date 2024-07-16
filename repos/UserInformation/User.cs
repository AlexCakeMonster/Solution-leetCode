using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInformation
{
    class User
    {
        string login, name, surname, age, date;

        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        public string Age
        {
            get => age;
            set => age = value;
        }

        public User()
        {
            date = Convert.ToString(DateTime.Now);
        }

        public string UserInformation()
        {
            string userInformation = $"login : {login}\n" + $"user name : {name}\n" + $"user surname : {surname}\n"
                 + $"user age : {age}\n" + $"account creation date : {date}";
            return userInformation;
        }
    }
}
