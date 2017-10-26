using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.ViewModels
{
    public class AdministratorViewModel : ObservableObject
    {
        // Fields
        #region Fields

        private Person _adminPerson = new Person();
        private ObservableCollection<PersonViewModel> _usersCollection = new ObservableCollection<PersonViewModel>();
        private ObservableCollection<ProjectViewModel> _projectsCollection = new ObservableCollection<ProjectViewModel>();

        #endregion

        // Properties
        #region Properties

        public string Name
        {
            get => _adminPerson.Name;
            set
            {
                _adminPerson.Name = value;
                RaisePropertyChangedEvent("Name");
            }
        }

        public string SurName
        {
            get => _adminPerson.SurName;
            set
            {
                _adminPerson.SurName = value;
                RaisePropertyChangedEvent("SurName");
            }
        }

        public string MiddleName
        {
            get => _adminPerson.MiddleName;
            set
            {
                _adminPerson.MiddleName = value;
                RaisePropertyChangedEvent("MiddleName");
            }
        }

        public string Email
        {
            get => _adminPerson.Email;
            set
            {
                _adminPerson.Email = value;
                RaisePropertyChangedEvent("Email");
            }
        }

        public string Password
        {
            get => _adminPerson.Password;
            set
            {
                _adminPerson.Password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        public int PersonID
        {
            get => _adminPerson.PersonID;
            set
            {
                _adminPerson.PersonID = value;
                RaisePropertyChangedEvent("PersonID");
            }
        }

        public ObservableCollection<PersonViewModel> UsersCollection
        {
            get => _usersCollection;
            set
            {
                _usersCollection = value;
                RaisePropertyChangedEvent("UsersCollection");
            }
        }

        public ObservableCollection<ProjectViewModel> ProjectsCollection
        {
            get => _projectsCollection;
            set
            {
                _projectsCollection = value;
                RaisePropertyChangedEvent("ProjectsCollection");
            }
        }

        #endregion

        // Constructors
        #region Constructors

        #endregion

        // Functions
        #region Functions

        #endregion
    }
}
