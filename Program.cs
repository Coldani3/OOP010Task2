using System;

namespace OOPAssignment010T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment(2, "011", DateTime.Now, DateTime.Now.AddDays(7));
            Module module = new Module("Object Oriented Programming", "MOD005437", new Assignment[] { assignment });
            Grade grade = new Grade(72, 0.7f, module, assignment);
            grade.Display();
        }
    }
}
