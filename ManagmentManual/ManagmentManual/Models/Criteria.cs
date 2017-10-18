using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Models
{
    public class Criteria
    { 
        // Fields
        #region Fields

        private int _time;
        private int _priority;
        private int _complexity;

        #endregion

        // Properties
        #region Properties

        public int Time
        {
            get => _time;
            set => _time = value;
        }

        public int Priority
        {
            get => _priority;
            set => _priority = value;
        }

        public int Complexity
        {
            get => _complexity;
            set => _complexity = value;
        }

        #endregion

        // Constructors
        #region Constructors

        public Criteria()
        {
            Time = 0;
            Priority = 0;
            Complexity = 0;
        }

        public Criteria(int time, int priority, int complexity)
        {
            Time = time;
            Priority = priority;
            Complexity = complexity;
        }

        public Criteria(Criteria defaultCriteria)
        {
            _time = defaultCriteria.Time;
            _priority = defaultCriteria.Priority;
            _complexity = defaultCriteria.Complexity;
        }

        public Criteria(Result defaultCriteria)
        {
            _time = defaultCriteria.RESULT_TIME;
            _priority = defaultCriteria.RESULT_PRIORITY;
            _complexity = defaultCriteria.RESULT_COMPLEXITY;
        }
        #endregion

        // Functions
        #region Functions
        #endregion
    }
}
