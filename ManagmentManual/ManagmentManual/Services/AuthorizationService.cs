using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Services
{
    public sealed class AuthorizationService
    {
        private static readonly AuthorizationService instance = new AuthorizationService();

        private AuthorizationService() { }

        public static AuthorizationService Instance
        {
            get => instance;
        }

        // Switch: 1 - user is admin; 2 - user is expert; 3 - user is student
        public int LogIn(string userEmail, string userPass)
        {
            var _currUser = MainWindow.DB_DATA.Users.FirstOrDefault(user =>
                (user.USER_EMAIL == userEmail && user.USER_PASSWORD == userPass));

            if (_currUser != null)
            {
                MainWindow.CURRENT_USER_ID = _currUser.USER_ID;
                return _currUser.USER_TYPE_ID;
            }
            else
            {
                throw new Exception("Your email or password is wrong! Please write correct data!");
            }
        }

        public void LogOut()
        {
            MainWindow.CURRENT_USER_ID = 0;
        }
    }
}
