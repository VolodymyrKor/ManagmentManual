using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public class TaskSolutionModal
    {
        // Fields
        #region Fields

        private System.DateTime _dateTime;
        private int _solutionId;
        private int _taskId;
        private int _personAnswererId;
        private Criteria _solutionResults;

        #endregion
        
        // Properties
        #region Properties

        public System.DateTime DateTime
        {
            get => _dateTime;
        }

        public int SolutionID
        {
            get => _solutionId;
            set => _solutionId = value;
        }

        public int TaskID
        {
            get => _taskId;
            set => _taskId = value;
        }

        public int PersonAnswererID
        {
            get => _personAnswererId;
            set => _personAnswererId = value;
        }

        public Criteria SolutionResults
        {
            get => _solutionResults;
            set => _solutionResults = value;
        }

        #endregion

        // Constructors
        #region Constructors

        public TaskSolutionModal()
        {
            _solutionResults = new Criteria();
        }

        public TaskSolutionModal(DateTime dateTime, int solutionId, int taskId, int personAnswererId, Criteria solutionResults)
        {
            _dateTime = dateTime;
            _solutionId = solutionId;
            _taskId = taskId;
            _personAnswererId = personAnswererId;
            _solutionResults = solutionResults;
        }

        public TaskSolutionModal(TaskSolutionModal taskSolutionModal)
        {
            _dateTime = taskSolutionModal.DateTime;
            _solutionId = taskSolutionModal.SolutionID;
            _taskId = taskSolutionModal.TaskID;
            _personAnswererId = taskSolutionModal.PersonAnswererID;
            _solutionResults = new Criteria(taskSolutionModal.SolutionResults);
        }

        public TaskSolutionModal(TaskSolution taskSolution)
        {
            _dateTime = taskSolution.TASK_SOLUTION_DATE;
            _solutionId = taskSolution.TASK_SOLUTION_ID;
            _taskId = taskSolution.TASK_SOLUTION_TASK_ID;
            _personAnswererId = taskSolution.TASK_SOLUTION_ANSWERER_ID;
            _solutionResults = new Criteria(taskSolution.Result);
        }

        #endregion

        // Functions
        #region Functions
        #endregion
    }
}
