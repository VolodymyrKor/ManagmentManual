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
    /// Логика взаимодействия для TestViewingExpertPage.xaml
    /// </summary>
    public partial class TestViewingExpertPage : Page
    {
        public TestViewingExpertPage()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new StartExpertPage());
        }
    }
}
