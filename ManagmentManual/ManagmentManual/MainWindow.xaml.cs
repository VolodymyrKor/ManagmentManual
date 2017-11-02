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
using ManagmentManual.Services;

namespace ManagmentManual
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global constants
        public static ManagmentManualDBEntities DB_DATA = new ManagmentManualDBEntities();
        public static AuthorizationService AUTHORIZATION_SERVICE = AuthorizationService.Instance;
        public static RegistrationService REGISTRATION_SERVICE = RegistrationService.Instance;
        public static SolutionService SOLUTION_SERVICE = SolutionService.Instance;
        public static ProjectService PROJECT_SERVICE = ProjectService.Instance;
        public static UserService USER_SERVICE = UserService.Instance;
        public static TaskService TASK_SERVICE = TaskService.Instance;
        public static int CURRENT_USER_ID = 0;

        public MainWindow()
        {
            InitializeComponent();

            MainFrame.NavigationService.Navigate(new TestViewingStudentPage());
        }
    }
}
