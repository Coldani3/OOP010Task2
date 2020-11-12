using System;
using System.Collections.Generic;

namespace OOPAssignment010T2
{
    public class Student
    {
        public string FirstName;
        public string MiddleName = "";
        public string LastName;
        public string StudentID;
        public string Email = "";
        public string StudentTelephoneNo = "";
        public string HomePhoneNo = "";
        public string ParentFirstName = "";
        public string ParentLastName = "";
        public string TermTimeAddress = "";
        public string HomeAddress = "";
        public List<Report> ReportCards = new List<Report>();
        public GradeProfile StudentGradeProfile = new GradeProfile();

        public Student(string firstName, string lastName, string studentID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentID = studentID;
        }

        public Student(string firstName, string lastName, string studentID, GradeProfile gradeProfile) : this(firstName,lastName,studentID)
        {
            this.StudentGradeProfile = gradeProfile;
        }
    }
}