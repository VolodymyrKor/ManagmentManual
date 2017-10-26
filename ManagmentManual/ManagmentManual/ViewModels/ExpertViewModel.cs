using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.ViewModels
{
    public class ExpertViewModel : ObservableObject 
    {
        // Fields
        #region Fields

        private Person _expertPerson = new Person();
        private ObservableCollection<ProjectViewModel> _projectsCollection = new ObservableCollection<ProjectViewModel>();

        #endregion

        // Properties
        #region Properties

        public string Name
        {
            get => _expertPerson.Name;
            set
            {
                _expertPerson.Name = value;
                RaisePropertyChangedEvent("Name");
            }
        }

        public string SurName
        {
            get => _expertPerson.SurName;
            set
            {
                _expertPerson.SurName = value;
                RaisePropertyChangedEvent("SurName");
            }
        }

        public string MiddleName
        {
            get => _expertPerson.MiddleName;
            set
            {
                _expertPerson.MiddleName = value;
                RaisePropertyChangedEvent("MiddleName");
            }
        }

        public string Email
        {
            get => _expertPerson.Email;
            set
            {
                _expertPerson.Email = value;
                RaisePropertyChangedEvent("Email");
            }
        }

        public string Password
        {
            get => _expertPerson.Password;
            set
            {
                _expertPerson.Password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        public int PersonID
        {
            get => _expertPerson.PersonID;
            set
            {
                _expertPerson.PersonID = value;
                RaisePropertyChangedEvent("PersonID");
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
