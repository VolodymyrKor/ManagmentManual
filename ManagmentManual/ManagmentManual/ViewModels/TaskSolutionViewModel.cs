
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.ViewModels
{
    public class TaskSolutionViewModel : ObservableObject
    {
        // Fields
        #region

        private TaskSolutionModel _taskSolution = new TaskSolutionModel();

        #endregion

        // Properties
        #region Properties

        public System.DateTime DateTime
        {
            get => _taskSolution.DateTime;
            set
            {
                _taskSolution.DateTime = value;
                RaisePropertyChangedEvent("DateTime");
            }
        }

        public int SolutionID
        {
            get => _taskSolution.SolutionID;
            set
            {
                _taskSolution.SolutionID = value;
                RaisePropertyChangedEvent("SolutionID");
            }
        }

        public int TaskID
        {
            get => _taskSolution.TaskID;
            set
            {
                _taskSolution.TaskID = value;
                RaisePropertyChangedEvent("TaskID");
            }
        }

        public int PersonAnswererID
        {
            get => _taskSolution.PersonAnswererID;
            set
            {
                _taskSolution.PersonAnswererID = value;
                RaisePropertyChangedEvent("PersonAnswererID");
            }
        }

        public int TaskSolutionTime
        {
            get => _taskSolution.SolutionResults.Time;
            set
            {
                _taskSolution.SolutionResults.Time = value;
                RaisePropertyChangedEvent("TaskSolutionTime");
            }
        }

        public int TaskSolutionPriority
        {
            get => _taskSolution.SolutionResults.Priority;
            set
            {
                _taskSolution.SolutionResults.Priority = value;
                RaisePropertyChangedEvent("TaskSolutionPriority");
            }
        }

        public int TaskSolutionComplexity
        {
            get => _taskSolution.SolutionResults.Complexity;
            set
            {
                _taskSolution.SolutionResults.Complexity = value;
                RaisePropertyChangedEvent("TaskSolutionComplexity");
            }
        }

        #endregion

        // Constructors
        #region Constructors

        public TaskSolutionViewModel() { }

        public TaskSolutionViewModel(TaskSolutionModel ts)
        {
            DateTime = ts.DateTime;
            SolutionID = ts.SolutionID;
            TaskID = ts.TaskID;
            PersonAnswererID = ts.PersonAnswererID;
            TaskSolutionTime = ts.SolutionResults.Time;
            TaskSolutionPriority = ts.SolutionResults.Priority;
            TaskSolutionComplexity = ts.SolutionResults.Complexity;
        }

        #endregion

        // Functions
        #region Functions

        public TaskSolutionModel GeTaskSolutionModel()
        {
            return _taskSolution;
        }

        #endregion
    }
}
