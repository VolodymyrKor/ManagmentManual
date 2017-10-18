using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public class Expert : Person
    {
        // Fields
        #region Fields
        #endregion

        // Properties
        #region Properties
        #endregion

        // Constructors
        #region Constructors

        public Expert() { }

        #endregion

        // Functions
        #region Functions

        public List<ProjectModel> GetMyProjects()
        {
            var list = new List<ProjectModel>();
            foreach (var project in MainWindow.DB_DATA.Projects.Where(p => p.PROJECT_OWNER_ID == PersonID).ToArray())
            {
                list.Add(new ProjectModel(project));
            }
            return list;
        }

        #endregion
    }
}
