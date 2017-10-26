using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.ViewModels
{
    // I am not assured that this class is needed
    public class CriteriaViewModel : ObservableObject
    {
        // Fields
        #region Fields

        private Criteria _criteria = new Criteria();

        #endregion

        // Properties
        #region Properties

        public int Time
        {
            get => _criteria.Time;
            set
            {
                _criteria.Time = value;
                RaisePropertyChangedEvent("Time");
            }
        }

        public int Priority
        {
            get => _criteria.Priority;
            set
            {
                _criteria.Priority = value;
                RaisePropertyChangedEvent("Priority");
            }
        }

        public int Complexity
        {
            get => _criteria.Complexity;
            set
            {
                _criteria.Complexity = value;
                RaisePropertyChangedEvent("Complexity");
            }
        }

        #endregion
    }
}
