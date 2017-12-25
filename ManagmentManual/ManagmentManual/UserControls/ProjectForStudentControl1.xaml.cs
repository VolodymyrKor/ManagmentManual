using ManagmentManual.Pages;
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

namespace ManagmentManual.UserControls
{
    /// <summary>
    /// Interaction logic for ProjectForStudentControl.xaml
    /// </summary>
    public partial class ProjectForStudentControl1 : UserControl
    {
        public ProjectForStudentControl1()
        {
            InitializeComponent();
        }

        private void StartTestButton_Click(object sender, RoutedEventArgs e)
        {
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new TestViewingStudentPage1());
        }
    }
}
