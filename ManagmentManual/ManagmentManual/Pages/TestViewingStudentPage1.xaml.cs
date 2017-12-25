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
    /// Interaction logic for TestViewingStudentPage.xaml
    /// </summary>
    public partial class TestViewingStudentPage1 : Page
    {
        public TestViewingStudentPage1()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartExpertPage());
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new ResultPage1());
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new LoginPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartStudentPage());
        }

        private void UserNameTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
