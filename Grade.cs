using System;

namespace OOPAssignment010T2
{
    public class Grade
    {
        public string GradeString { get => OOPUtil.MarksToGrade(this.Mark); }
        public int Mark { get; private set; }
        public float Weight;
        public Module Module { get; private set; }
        public Assignment Assignment { get; private set; }

        public Grade(int mark, float weight, Module module, Assignment assignment) : this(mark, weight, module)
        {
            this.Assignment = assignment;
        }

        public Grade(int mark, float weight, Module module) : this(mark, weight)
        {
            this.Module = module;
        }

        public Grade(int mark, float weight)
        {
            this.Mark = mark;
            this.Weight = weight;
        }

        public void Display()
        {
            if (this.Module != null)
            {
                Console.WriteLine($"Module: {this.Module.ModuleName}, {this.Module.ModuleCode}");
            }

            if (this.Assignment != null)
            {
                Console.WriteLine($"Assignment ID: {this.Assignment.AssignmentID}, Assignment No: {this.Assignment.AssignmentNo}");
            }

            Console.WriteLine($"Grade: {this.GradeString}, {this.Mark}/100, Weight: {this.Weight}");
        }
    }
}