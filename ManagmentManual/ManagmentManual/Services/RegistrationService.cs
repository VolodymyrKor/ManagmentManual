using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Services
{
    public sealed class RegistrationService
    {
        private static readonly RegistrationService instance = new RegistrationService();

        private RegistrationService() { }

        public static RegistrationService Instance
        {
            get => instance;
        }

        public bool Register(string userName, string userSurname, string userMiddleName, string userEmail, string userPassword)
        {
            if (MainWindow.DB_DATA.Users.Any(user => user.USER_EMAIL == userEmail))
            {
                throw new Exception("User with this email already exists!");
            }

            var registration = MainWindow.USER_SERVICE.AddUser(userName, userSurname, userMiddleName, userEmail, userPassword, 3);

            if (registration != 0)
            {
                MainWindow.CURRENT_USER_ID = registration;
                return true;
            }
            return false;
        }
    }
}
