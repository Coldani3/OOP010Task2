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

        public Grade(int mark, float weight, Module module)
        {
            this.Mark = mark;
            this.Weight = weight;
            this.Module = module;
        }

        public void Display()
        {
            Console.WriteLine($"Module: {this.Module.ModuleName}, {this.Module.ModuleCode}");

            if (this.Assignment != null)
            {
                Console.WriteLine($"Assignment ID: {this.Assignment.AssignmentID}");
                Console.WriteLine($"Assignment No: {this.Assignment.AssignmentNo}");
            }

            Console.WriteLine($"Grade: {this.GradeString}, {this.Mark}/100");
            Console.WriteLine($"Weight: {this.Weight}");
        }
    }
}