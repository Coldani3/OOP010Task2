using System;
using System.Collections.Generic;

namespace OOPAssignment010T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input student first name:");
            string studentFirstName = Console.ReadLine();
            Console.WriteLine("Input student first name (press enter to skip):");
            string studentMiddleName = Console.ReadLine();
            Console.WriteLine("Input student last name:");
            string studentLastName = Console.ReadLine();
            Console.WriteLine("Input student ID:");
            string studentID = Console.ReadLine();
            Console.WriteLine("Input student gender ('None' or 'Prefer not to say' where appropriate):");
            string studentGender = Console.ReadLine();

            //TODO: optional fields

            Student student = new Student(studentFirstName, studentLastName, studentID, studentGender);
            student.MiddleName = studentMiddleName;

            Assignment assignment = new Assignment(2, "011", DateTime.Now, DateTime.Now.AddDays(7));
            Assignment assignment2 = new Assignment(1, "010", DateTime.Now, DateTime.Now.AddDays(7));

            Module module = new Module("Object Oriented Programming", "MOD005437", assignment, assignment2);
            Grade grade = new Grade(72, 0.7f, module, assignment);
            Grade grade2 = new Grade(40, 0.3f, module, assignment2);
            GradeProfile profile = new GradeProfile();

            profile.AddGrades(module, grade, grade2);
            Report report = new Report(profile, DateTime.Now);
            student.StudentGradeProfile = profile;
            student.ReportCards.Add(report);

            // profile.Display();
            // OOPUtil.WriteThickDivider();
            //report.Display();
            student.DisplayDetails();
        }
    }
}
