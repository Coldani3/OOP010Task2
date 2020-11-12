using System.Collections.Generic;

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

            //TODO stringify

            return "";
        }

        public void AddGrade(Grade grade)
        {
            this.Grades[grade.Module].Add(grade);
        }
    }
}