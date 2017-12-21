using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.Services
{
    public sealed class UserService
    {
        private static readonly UserService instance = new UserService();

        private UserService() { }

        public static UserService Instance
        {
            get => instance;
        }

        // return user id or 0 if user can not be added
        public int AddUser(string userName, string userSurname, string userMiddleName, string userEmail, string userPassword, int userType)
        {
            MainWindow.DB_DATA.Users.Add(new User()
            {
                USER_NAME = userName,
                USER_SURNAME = userSurname,
                USER_MIDDLE_NAME = userMiddleName,
                USER_EMAIL = userEmail,
                USER_PASSWORD = userPassword,
                USER_TYPE_ID = userType
            });

            if (MainWindow.DB_DATA.SaveChanges() > 0)
            {
                MainWindow.CURRENT_USER_ID = MainWindow.DB_DATA.Users
                    .FirstOrDefault(user => user.USER_EMAIL == userEmail).USER_ID;

                return MainWindow.CURRENT_USER_ID;
            }
            return 0;
        }

        // return user id or 0 if user can not be added
        public int AddUser(Person newUser)
        {
            var userType = 0;
            if (newUser.PersonType == PersonTypes.Administrator)
                userType = 1;
            if (newUser.PersonType == PersonTypes.Expert)
                userType = 2;
            if (newUser.PersonType == PersonTypes.Student)
                userType = 3;

            MainWindow.DB_DATA.Users.Add(new User()
            {
                USER_NAME = newUser.Name,
                USER_SURNAME = newUser.SurName,
                USER_MIDDLE_NAME = newUser.MiddleName,
                USER_EMAIL = newUser.Email,
                USER_PASSWORD = newUser.Password,
                USER_TYPE_ID = userType
            });

            if (MainWindow.DB_DATA.SaveChanges() > 0)
            {
                return MainWindow.DB_DATA.Users
                    .FirstOrDefault(user => user.USER_EMAIL == newUser.Email).USER_ID;
            }
            return 0;
        }

        public List<Person> GetAllUsers()
        {
            var _users = new List<Person>();
            foreach(var user in MainWindow.DB_DATA.Users)
            {
                _users.Add(new Person(user));
            }
            return _users;    
        }
    }
}
