using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManagmentManual.Pages;

namespace ManagmentManual
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void AboutBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AboutPage());
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new HelpPage());
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var _userEmail = EmailTextBox.Text;
                var _userPass = PassTextBox.Text;

                var _currUser = MainWindow.DB_DATA.Users.FirstOrDefault(user =>
                    (user.USER_EMAIL == _userEmail && user.USER_PASSWORD == _userPass));

                if (_currUser != null)
                {
                    MainWindow.CURRENT_USER_ID = _currUser.USER_ID;
                    Page nextPage;
                    switch (_currUser.UserType.TYPE_ID)
                    {
                        case 1:
                            nextPage = new StartAdminPage();
                            break;
                        case 2:
                            nextPage = new StartExpertPage();
                            break;
                        case 3:
                            nextPage = new StartStudentPage();
                            break;
                        default:
                            nextPage = null;
                            break;
                    }
                    if (nextPage != null)
                    {
                        NavigationService?.Navigate(nextPage);
                    }
                    else
                    {
                        throw new Exception("Undefined type of user");
                    }
                }
                else
                {
                    throw new Exception("Your email or password is wrong! Please write correct data");
                }
            }
            catch (Exception exception)
            {
                // Todo [VK]: create cool design for any problems
                MessageBox.Show("Smth went wrong!" + exception.Message, "Error");
            }
        }

        private void RegisterBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new RegistrationPage());
        }
    }
}
