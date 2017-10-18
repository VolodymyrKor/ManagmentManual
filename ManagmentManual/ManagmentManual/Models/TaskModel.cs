using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public class TaskModel
    {
        // Fields
        #region Fields

        private string _taskName;
        private string _taskDescription;
        private int _taskId;
        private int _parentProjectId;
        private Criteria _taskExpectedCriteria;

        #endregion

        // Properties
        #region Properties

        public string TaskName
        {
            get => _taskName;
            set => _taskName = value;
        }

        public string TaskDescription
        {
            get => _taskDescription;
            set => _taskDescription = value;
        }

        public int TaskID
        {
            get => _taskId;
            set => _taskId = value;
        }

        public int ParentProjectID
        {
            get => _parentProjectId;
            set => _parentProjectId = value;
        }

        public Criteria TaskExpectedCriteria
        {
            get => _taskExpectedCriteria;
            set => _taskExpectedCriteria = value;
        }

        #endregion

        // Constructors
        #region Constructors

        public TaskModel()
        {
            _taskExpectedCriteria = new Criteria();
        }

        public TaskModel(string taskName, string taskDescription, int taskId, int parentProjectId, Criteria taskExpectedCriteria)
        {
            _taskName = taskName;
            _taskDescription = taskDescription;
            _taskId = taskId;
            _parentProjectId = parentProjectId;
            _taskExpectedCriteria = new Criteria(taskExpectedCriteria);
        }

        public TaskModel(TaskModel taskModel)
        {
            _taskName = taskModel.TaskName;
            _taskDescription = taskModel.TaskDescription;
            _taskId = taskModel.TaskID;
            _parentProjectId = taskModel.ParentProjectID;
            _taskExpectedCriteria = new Criteria(taskModel.TaskExpectedCriteria);
        }

        public TaskModel(Task task)
        {
            _taskName = task.TASK_NAME;
            _taskDescription = task.TASK_DESCRIPTION;
            _taskId = task.TASK_ID;
            _parentProjectId = task.TASK_PROJECT_ID;
            _taskExpectedCriteria = new Criteria()
            {
                Time = task.TASK_EXPECTED_TIME,
                Priority = task.TASK_EXPECTED_PRIORITY,
                Complexity = task.TASK_EXPECTED_COMPLEXITY
            };
        }

        #endregion

        // Functions
        #region Functions
        #endregion
    }
}
