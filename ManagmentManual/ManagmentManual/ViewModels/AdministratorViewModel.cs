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
        private ObservableCollection<PersonViewModel> _adminsCollection = new ObservableCollection<PersonViewModel>();
        private ObservableCollection<PersonViewModel> _expertsCollection = new ObservableCollection<PersonViewModel>();
        private ObservableCollection<PersonViewModel> _studentsCollection = new ObservableCollection<PersonViewModel>();

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

        public ObservableCollection<PersonViewModel> AdminsCollection
        {
            get => _adminsCollection;
            set
            {
                _adminsCollection = value;
                RaisePropertyChangedEvent("AdminsCollection");
            }
        }

        public ObservableCollection<PersonViewModel> ExpertsCollection
        {
            get => _expertsCollection;
            set
            {
                _expertsCollection = value;
                RaisePropertyChangedEvent("ExpertsCollection");
            }
        }

        public ObservableCollection<PersonViewModel> StudentsCollection
        {
            get => _studentsCollection;
            set
            {
                _studentsCollection = value;
                RaisePropertyChangedEvent("StudentsCollection");
            }
        }

        #endregion

        // Constructors
        #region Constructors

        #endregion

        // Functions
        #region Functions

        public void LoadInfo()
        {
            foreach (var user in MainWindow.USER_SERVICE.GetAllUsers())
            {
                switch(user.PersonType)
                {
                    case PersonTypes.Administrator:
                        AdminsCollection.Add(new PersonViewModel(user));
                        break;
                    case PersonTypes.Expert:
                        ExpertsCollection.Add(new PersonViewModel(user));
                        break;
                    case PersonTypes.Student:
                        StudentsCollection.Add(new PersonViewModel(user));
                        break;
                }
            }
        }

        #endregion
    }
}
