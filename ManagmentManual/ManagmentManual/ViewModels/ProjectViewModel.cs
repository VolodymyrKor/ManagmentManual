using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.ViewModels
{
    public class ProjectViewModel : ObservableObject
    {
        // Fields
        #region Fields

        private ProjectModel _projectModel = new ProjectModel();
        private ObservableCollection<TaskViewModel> _taskViewModels = new ObservableCollection<TaskViewModel>();

        #endregion

        // Properties
        #region Properties

        public string ProjectName
        {
            get => _projectModel.ProjectName;
            set
            {
                _projectModel.ProjectName = value; 
                RaisePropertyChangedEvent("ProjectName");
            }
        }

        public string ProjectDescription
        {
            get => _projectModel.ProjectDescription;
            set
            {
                _projectModel.ProjectDescription = value;
                RaisePropertyChangedEvent("ProjectDescription");    
            }
        }

        public int ProjectID
        {
            get => _projectModel.ProjectID;
            set
            {
                _projectModel.ProjectID = value;
                RaisePropertyChangedEvent("ProjectID");
            }
        }

        public int ProjectOwnerID
        {
            get => _projectModel.ProjectOwnerID;
            set
            {
                _projectModel.ProjectOwnerID = value;
                RaisePropertyChangedEvent("ProjectOwnerID");
            }
        }

        public ObservableCollection<TaskViewModel> TaskViewModels
        {
            get => _taskViewModels;
            set
            {
                _taskViewModels = value;
                RaisePropertyChangedEvent("TaskViewModels");
            }
        }

        #endregion

        // Constructors
        #region Constructors

        public ProjectViewModel() { }

        public ProjectViewModel(ProjectModel pm)
        {
            ProjectName = pm.ProjectName;
            ProjectDescription = pm.ProjectDescription;
            ProjectID = pm.ProjectID;
            ProjectOwnerID = pm.ProjectOwnerID;

            foreach(var task in MainWindow.DB_DATA.Tasks.Where(task => task.TASK_PROJECT_ID == _projectModel.ProjectID))
            {
                TaskViewModels.Add(new TaskViewModel(new TaskModel(task)));
            }
        }

        #endregion

        // Functions
        #region Functions

        public ProjectModel GetProjectModel()
        {
            return _projectModel;
        }

        public List<TaskViewModel> GetProjectTaskViewModels()
        {
            var _list = new List<TaskViewModel>();
            foreach (var task in _taskViewModels)
            {
                _list.Add(task);
            }
            return _list;
        }

        #endregion

    }
}
