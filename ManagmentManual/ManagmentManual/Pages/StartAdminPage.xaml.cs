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
    /// Interaction logic for StartAdminPage.xaml
    /// </summary>
    public partial class StartAdminPage : Page
    {
        public StartAdminPage()
        {
            InitializeComponent();
        }

        private void ExpertsSection_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ExpertsSection.Width = new GridLength(2, GridUnitType.Star);
            StudentsSection.Width = new GridLength(0.1, GridUnitType.Star);
            StudentsScroV.Opacity = 0.5;
            ExpertsScroV.Opacity = 1;
        }

        private void StudentsSection_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ExpertsSection.Width = new GridLength(0.1, GridUnitType.Star);
            StudentsSection.Width = new GridLength(2, GridUnitType.Star);
            StudentsScroV.Opacity = 1;
            ExpertsScroV.Opacity = 0.5;
        }

        private void ExpertsSection_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
