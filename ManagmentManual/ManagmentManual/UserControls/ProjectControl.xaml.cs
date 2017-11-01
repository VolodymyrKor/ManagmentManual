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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManagmentManual.Models;
using ManagmentManual.Pages;

namespace ManagmentManual.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class ProjectControl : UserControl
    {
        public ProjectControl()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //NavigationService?.Navigate(new TestViewingExpertPage());
            var service = NavigationService.GetNavigationService(this);
            service.Navigate(new TestViewingExpertPage());
        }

        
    }
    }

