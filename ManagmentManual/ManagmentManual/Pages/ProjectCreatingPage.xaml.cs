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
    /// Логика взаимодействия для ProjectCreatingPage.xaml
    /// </summary>
    public partial class ProjectCreatingPage : Page
    {
        public ProjectCreatingPage()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e) //exit
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new LoginPage());

        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e) //savng the results
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartExpertPage());
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e) //get back
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartExpertPage());
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new LoginPage());
        }

        private void UserNameTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartExpertPage());
        }
    }
}
