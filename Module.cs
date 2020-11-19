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
            this.Assignments = assignments;
        }
    }
}