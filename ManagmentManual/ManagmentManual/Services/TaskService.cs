using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

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
        public List<TaskModel> GetTasksInProject(int projectId)
        {
            var list = new List<TaskModel>();
            foreach (var project in MainWindow.DB_DATA.Tasks.Where(task => task.TASK_PROJECT_ID == projectId))
            {
                list.Add(new TaskModel(project));
            }
            return list;
        }
    }
}
