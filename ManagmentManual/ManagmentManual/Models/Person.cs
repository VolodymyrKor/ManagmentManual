using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public class Person
    {
        // Fields
        #region Fields

        private string _name;
        private string _surName;
        private string _middleName;
        private string _email;
        private string _password;
        private int _personId;
        private PersonTypes _personType;

        #endregion

        // Properties
        #region Properties

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string SurName
        {
            get => _surName;
            set => _surName = value;
        }

        public string MiddleName
        {
            get => _middleName;
            set => _middleName = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public int PersonID
        {
            get => _personId;
            set => _personId = value;
        }

        public PersonTypes PersonType
        {
            get => _personType;
            set => _personType = value;
        }

        #endregion

        // Constructors
        #region Constructors

        public Person() { }

        public Person(User user)
        {
            Name = user.USER_NAME;
            SurName = user.USER_SURNAME;
            MiddleName = user.USER_MIDDLE_NAME;
            Email = user.USER_EMAIL;
            Password = user.USER_PASSWORD;
            PersonID = user.USER_ID;
            PersonType = (PersonTypes)user.USER_TYPE_ID;
        }

        #endregion

        // Functions
        #region Functions

        public List<ProjectModel> GetAllProjects()
        {
            return MainWindow.PROJECT_SERVICE.GetAllProjects();
        }

        #endregion

    }


    // User types
    public enum PersonTypes
    {
        Administrator = 1,
        Expert = 2,
        Student = 3
    }
}
