using System.Linq;

namespace OOPAssignment010T2
{
    public class Module
    {
        public string ModuleName { get; private set; }
        public string ModuleCode { get; private set; }
        public Assignment[] Assignments = new Assignment[2];

        public Module(string moduleName, string moduleCode, params Assignment[] assignments)
        {
            this.ModuleName = moduleName;
            this.ModuleCode = moduleCode;

            if (assignments.Length <= 2)
            {
                this.Assignments = assignments;
            }
            else
            {
                this.Assignments = (Assignment[]) assignments.Take(2);
            }
        }
    }
}