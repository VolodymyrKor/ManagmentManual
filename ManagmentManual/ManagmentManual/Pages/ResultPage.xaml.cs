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
    /// Interaction logic for ResultPage.xaml
    /// </summary>
    public partial class ResultPage : Page
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new LoginPage());
        }

        private void UserNameTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ReturnToTestsBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartStudentPage());
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new LoginPage());
        }
    }
}
