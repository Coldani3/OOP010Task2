using System.Collections.Generic;
using System;

namespace OOPAssignment010T2
{
    public class GradeProfile
    {
        public Dictionary<Module, List<Grade>> Grades = new Dictionary<Module, List<Grade>>();

        public string GetAverageGrade()
        {
            int gradeCount = 0;
            int marks = 0;

            foreach (List<Grade> grades in this.Grades.Values)
            {
                foreach (Grade grade in grades)
                {
                    marks += grade.Mark;
                }

                gradeCount++;
            }

            int averageMarks = marks / gradeCount;
            return OOPUtil.MarksToGrade(averageMarks);
        }

        public void AddGrade(Grade grade)
        {
            this.Grades[grade.Module].Add(grade);
        }

        public void AddGrade(Module module, Grade grade)
        {
            this.Grades.Add(module, new List<Grade>() {grade});
        }

        public void AddGrades(Module module, params Grade[] grades)
        {
            this.Grades.Add(module, new List<Grade>(grades));
        }

        public void Display()
        {
            if (this.Grades.Count > 0)
            {
                foreach (Module module in this.Grades.Keys)
                {
                    if (this.Grades[module].Count > 0)
                    {
                        Console.WriteLine($"Grades for Module {module.ModuleName}, {module.ModuleCode}:");

                        foreach (Grade grade in this.Grades[module])
                        {
                            grade.Display();
                            Console.Write("\n");
                        }
                    }

                    OOPUtil.WriteThinDivider();
                }
            }
        }
    }
}