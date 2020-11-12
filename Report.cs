using System;
using System.Collections.Generic;

namespace OOPAssignment010T2
{
    public class Report
    {
        private GradeProfile studentGradeProfile;
        public Dictionary<Module, Grade> ModuleGrades = new Dictionary<Module, Grade>();
        public DateTime Date;

        public Report(GradeProfile studentGradeProfile, DateTime date)
        {
            this.studentGradeProfile = studentGradeProfile;
            this.Date = date;

            this.CalculateFromStudentGradeProfile();
        }

        private void CalculateFromStudentGradeProfile()
        {
            foreach (Module module in this.studentGradeProfile.Grades.Keys)
            {
                int totalMarks = 0;

                foreach (Grade grade in this.studentGradeProfile.Grades[module])
                {
                    totalMarks += (int) (grade.Mark * grade.Weight);
                }

                this.ModuleGrades.Add(module, new Grade(totalMarks, 1.00f, module));
            }
        }

        public string GetAverageGrade()
        {
            int gradeCount = 0;
            int gradeTotal = 0;

            foreach (Grade grade in this.ModuleGrades.Values)
            {
                gradeCount++;
                gradeTotal += grade.Mark;
            }

            return OOPUtil.MarksToGrade(gradeTotal);
        }

        public string GetHumanReadableDate()
        {
            return this.Date.ToString();
        }
    }
}