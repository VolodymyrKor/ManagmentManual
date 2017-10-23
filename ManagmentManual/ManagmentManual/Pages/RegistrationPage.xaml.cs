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

namespace ManagmentManual.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegisterStudentButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (StudentPasswordTextBox.Password != StudentPassword2TextBox.Password)
                {
                    throw new Exception("Passwords are not equal!");
                }
                var registration = MainWindow.REGISTRATION_SERVICE.Register(
                    StudentNameTextBox.Text,
                    StudentSurnameTextBox.Text,
                    StudentMiddleNameTextBox.Text,
                    StudentEmailTextBox.Text,
                    StudentPasswordTextBox.Password);
                if (registration)
                {
                    NavigationService?.Navigate(new StartStudentPage());
                }
                else
                {
                    throw new Exception("Problem with registration. Please try again.");
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show(exception.Message + "\n" + "Some problems with database(((", "Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void BackToStartPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.GoBack();
        }
    }
}
