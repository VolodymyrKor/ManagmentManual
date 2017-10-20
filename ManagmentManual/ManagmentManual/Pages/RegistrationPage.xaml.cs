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
                if (MainWindow.DB_DATA.Users.Any(user => user.USER_EMAIL == StudentEmailTextBox.Text))
                {
                    throw new Exception("User with this email already exists!");
                }

                MainWindow.DB_DATA.Users.Add(new User()
                {
                    USER_NAME = StudentNameTextBox.Text,
                    USER_SURNAME = StudentSurnameTextBox.Text,
                    USER_MIDDLE_NAME = StudentMiddleNameTextBox.Text,
                    USER_EMAIL = StudentEmailTextBox.Text,
                    USER_PASSWORD = StudentPasswordTextBox.Password,
                    // todo [VK]: check on null pointer
                    // todo [VK]: why too big id???
                    USER_TYPE_ID = MainWindow.DB_DATA.UserTypes.FirstOrDefault(type => type.TYPE_NAME == "student").TYPE_ID
                });

                if (MainWindow.DB_DATA.SaveChanges() > 0)
                {
                    MainWindow.CURRENT_USER_ID = MainWindow.DB_DATA.Users
                        .FirstOrDefault(user => user.USER_EMAIL == StudentEmailTextBox.Text).USER_ID;

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
