using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public abstract class Person
    {
        // Fields
        #region Fields

        private string _name;
        private string _surName;
        private string _middleName;
        private string _email;
        private string _password;
        private int _personId;

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

        #endregion

        // Functions
        #region Functions
            
        public virtual List<ProjectModel> GetAllProjects()
        {
            var list = new List<ProjectModel>();
            foreach (var project in MainWindow.DB_DATA.Projects)
            {
                list.Add(new ProjectModel(project));
            }
            return list;
        }

        #endregion

    }
}
