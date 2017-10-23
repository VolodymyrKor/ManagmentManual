using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentManual.Services
{
    public sealed class SolutionService
    {
        private static readonly SolutionService instance = new SolutionService();

        private SolutionService() { }

        public static SolutionService Instance
        {
            get => instance;
        }
    }
}
