using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;
using System.Collections.ObjectModel;

namespace ManagmentManual.ViewModels
{
    public class PersonViewModel : ObservableObject
    {
        // Fields
        #region
     
        private Person _person = new Person();
        private ObservableCollection<ProjectViewModel> _projectViewModels = new ObservableCollection<ProjectViewModel>();

        #endregion

        // Properties
        #region Properties

        public string Name
        {
            get => _person.Name;
            set
            {
                _person.Name = value;
                RaisePropertyChangedEvent("Name");
            }
        }

        public string SurName
        {
            get => _person.SurName;
            set
            {
                _person.SurName = value;
                RaisePropertyChangedEvent("SurName");
            }
        }

        public string MiddleName
        {
            get => _person.MiddleName;
            set
            {
                _person.MiddleName = value;
                RaisePropertyChangedEvent("MiddleName");
            }
        }

        public string Email
        {
            get => _person.Email;
            set
            {
                _person.Email = value;
                RaisePropertyChangedEvent("Email");
            }
        }

        public string Password
        {
            get => _person.Password;
            set
            {
                _person.Password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        public int PersonID
        {
            get => _person.PersonID;
            set
            {
                _person.PersonID = value;
                RaisePropertyChangedEvent("PersonID");
            }
        }

        public String PersonType
        {
            get => _person.PersonType.ToString();
            set
            {
                var inputedType = value;
                if (inputedType == PersonTypes.Administrator.ToString())
                {
                    _person.PersonType = PersonTypes.Administrator;
                }
                if (inputedType == PersonTypes.Expert.ToString())
                {
                    _person.PersonType = PersonTypes.Expert;
                }
                if (inputedType == PersonTypes.Student.ToString())
                {
                    _person.PersonType = PersonTypes.Student;
                }
                RaisePropertyChangedEvent("PersonType");
            }
        }

        public string FullName
        {
            get => _person.SurName + " " +
                   _person.Name + " " +
                   _person.MiddleName;
        }

        public ObservableCollection<ProjectViewModel> ProjectViewModels
        {
            get => _projectViewModels;
            set
            {
                _projectViewModels = value;
                RaisePropertyChangedEvent("ProjectViewModels");
            }
        }

        #endregion

        // Constructors
        #region Constructors

        public PersonViewModel() { }

        public PersonViewModel(Person person)
        {
            _person = person;
            foreach(var project in MainWindow.DB_DATA.Projects.Where(project => project.PROJECT_OWNER_ID == _person.PersonID))
            {
                ProjectViewModels.Add(new ProjectViewModel(new ProjectModel(project)));
            }
        }

        #endregion

        // Functions
        #region Functions

        #endregion
    }
}
