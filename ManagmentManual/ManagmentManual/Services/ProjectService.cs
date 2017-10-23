using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
