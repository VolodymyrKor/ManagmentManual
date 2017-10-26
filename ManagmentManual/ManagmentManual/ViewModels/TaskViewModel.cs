using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.ViewModels
{
    public class TaskViewModel : ObservableObject
    {
        // Fields
        #region

        private TaskModel _taskModel = new TaskModel();
        private ObservableCollection<TaskSolutionViewModel> _taskSolutionViewModels = new ObservableCollection<TaskSolutionViewModel>();

        #endregion

        // Properties
        #region Properties

        public string TaskName
        {
            get => _taskModel.TaskName;
            set
            {
                _taskModel.TaskName = value;
                RaisePropertyChangedEvent("TaskName");
            }
        }

        public string TaskDescription
        {
            get => _taskModel.TaskDescription;
            set
            {
                _taskModel.TaskDescription = value;
                RaisePropertyChangedEvent("TaskDescription");
            }
        }

        public int TaskID
        {
            get => _taskModel.TaskID;
            set
            {
                _taskModel.TaskID = value;
                RaisePropertyChangedEvent("TaskID");
            }
        }

        public int ParentProjectID
        {
            get => _taskModel.ParentProjectID;
            set
            {
                _taskModel.ParentProjectID = value;
                RaisePropertyChangedEvent("ParentProjectID");
            }
        }

        public int TaskExpectedTime
        {
            get => _taskModel.TaskExpectedCriteria.Time;
            set
            {
                _taskModel.TaskExpectedCriteria.Time = value;
                RaisePropertyChangedEvent("TaskExpectedCriteria");
            }
        }

        public int TaskExpectedPriority
        {
            get => _taskModel.TaskExpectedCriteria.Priority;
            set
            {
                _taskModel.TaskExpectedCriteria.Priority = value;
                RaisePropertyChangedEvent("TaskExpectedPriority");
            }
        }

        public int TaskExpectedComplexity
        {
            get => _taskModel.TaskExpectedCriteria.Complexity;
            set
            {
                _taskModel.TaskExpectedCriteria.Complexity = value;
                RaisePropertyChangedEvent("TaskExpectedComplexity");
            }
        }

        public ObservableCollection<TaskSolutionViewModel> TaskSolutionViewModels
        {
            get => _taskSolutionViewModels;
            set
            {
                _taskSolutionViewModels = value;
                RaisePropertyChangedEvent("TaskSolutionViewModels");
            }
        }

        #endregion

        // Constructors
        #region Constructors

        public TaskViewModel() { }

        public TaskViewModel(TaskModel tm)
        {
            TaskName = tm.TaskName;
            TaskDescription = tm.TaskDescription;
            TaskExpectedTime = tm.TaskExpectedCriteria.Time;
            TaskExpectedPriority = tm.TaskExpectedCriteria.Priority;
            TaskExpectedComplexity = tm.TaskExpectedCriteria.Complexity;
        }

        #endregion

        // Functions
        #region Functions

        public TaskModel GeTaskModel()
        {
            return _taskModel;
        }

        #endregion

    }
}
