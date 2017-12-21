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
using ManagmentManual.Models;
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
            if(EmailTextBox.Text == "student")
                NavigationService?.Navigate(new StartStudentPage());
            else if(EmailTextBox.Text == "expert")
                NavigationService?.Navigate(new StartExpertPage());
            //no need for that, we'll handle it later(no) after demo
            /*try
            {
                var userType = MainWindow.AUTHORIZATION_SERVICE.LogIn(EmailTextBox.Text, PassTextBox.Text);

                 Page nextPage = null;
                 switch (userType)
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
                         throw new Exception("Unknown user type!");
                 }*/
                nextPage = new StartStudentPage();
                NavigationService?.Navigate(nextPage);
            }
            catch (Exception exception)
            {
                // Todo [VK]: create cool design for any problems
                MessageBox.Show("Smth went wrong! " + exception.Message, "Error");
            }*/
        }

        private void RegisterBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService?.Navigate(new RegistrationPage());
        }
    }
}
