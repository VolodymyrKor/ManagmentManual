using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Services
{
    public sealed class TaskService
    {
        private static readonly TaskService instance = new TaskService();

        private TaskService() { }

        public static TaskService Instance
        {
            get => instance;
        }
    }
}
