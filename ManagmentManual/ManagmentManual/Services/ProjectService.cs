using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentManual.Models;

namespace ManagmentManual.Services
{
    public sealed class ProjectService
    {
        private static readonly ProjectService instance = new ProjectService();

        private ProjectService() { }

        public static ProjectService Instance
        {
            get => instance;
        }

        public List<ProjectModel> GetAllProjects()
        {
            var list = new List<ProjectModel>();
            foreach (var project in MainWindow.DB_DATA.Projects)
            {
                list.Add(new ProjectModel(project));
            }
            return list;
        }

        public List<ProjectModel> GetProjectsByID(int userId)
        {
            var list = new List<ProjectModel>();
            foreach (var project in MainWindow.DB_DATA.Projects.Where(project => project.PROJECT_OWNER_ID == userId))
            {
                list.Add(new ProjectModel(project));
            }
            return list;
        }
    }
}
