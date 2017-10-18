using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public class ProjectModel
    {
        // Fields
        #region Fields

        private string _projectName;
        private string _projectDescription;
        private int _projectId;
        private int _projectOwnerId;

        #endregion

        // Properties
        #region Properties

        public string ProjectName
        {
            get => _projectName;
            set => _projectName = value;
        }

        public string ProjectDescription
        {
            get => _projectDescription;
            set => _projectDescription = value;
        }

        public int ProjectID
        {
            get => _projectId;
            set => _projectId = value;
        }

        public int ProjectOwnerID
        {
            get => _projectOwnerId;
            set => _projectOwnerId = value;
        }

        #endregion

        // Constructors
        #region Constructors

        public ProjectModel() {}

        public ProjectModel(string projectName, string projectDescription, int projectId, int personOwnerId)
        {
            _projectName = projectName;
            _projectDescription = projectDescription;
            _projectId = projectId;
            _projectOwnerId = personOwnerId;
        }

        public ProjectModel(ProjectModel projectModel)
        {
            _projectName = projectModel.ProjectName;
            _projectDescription = projectModel.ProjectDescription;
            _projectId = projectModel.ProjectID;
            _projectOwnerId = projectModel.ProjectOwnerID;
        }

        public ProjectModel(Project dbProject)
        {
            _projectOwnerId = dbProject.PROJECT_OWNER_ID;
            _projectName = dbProject.PROJECT_NAME;
            _projectDescription = dbProject.PROJECT_DESCRIPTION;
            _projectId = dbProject.PROJECT_ID;
        }

        #endregion

        // Functions
        #region Functions
        #endregion
    }
}
