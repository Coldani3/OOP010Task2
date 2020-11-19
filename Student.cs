using System;
using System.Collections.Generic;

namespace OOPAssignment010T2
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public string StudentID;
        //Optional fields
        public string MiddleName = "";
        public string Email = "";
        public string StudentTelephoneNo = "";
        public string HomePhoneNo = "";
        public string ParentFirstName = "";
        public string ParentLastName = "";
        public string TermTimeAddress = "";
        public string HomeAddress = "";
        public List<Report> ReportCards = new List<Report>();
        public GradeProfile StudentGradeProfile = new GradeProfile();

        public Student(string firstName, string lastName, string studentID, string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentID = studentID;
            this.Gender = gender;
        }

        public Student(string firstName, string lastName, string studentID, string gender, GradeProfile gradeProfile) : this(firstName,lastName,studentID,gender)
        {
            this.StudentGradeProfile = gradeProfile;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {this.FirstName} " + (this.MiddleName != "" ? this.MiddleName + " " : "") + this.LastName);
            Console.WriteLine($"Gender: {this.Gender}");
            Console.WriteLine($"Student ID: {this.StudentID}");
            OOPUtil.WriteIfExists(this.Email, $"Email: {this.Email}");
            OOPUtil.WriteIfExists(this.StudentTelephoneNo, $"Student Tel No.: {this.StudentTelephoneNo}");
            OOPUtil.WriteIfExists(this.HomePhoneNo, $"Home Phone No.: {this.HomePhoneNo}");
            OOPUtil.WriteIfExists(this.HomeAddress, $"Home Address: {this.HomeAddress}");
            OOPUtil.WriteIfExists(this.TermTimeAddress, $"Term Time Address: {this.TermTimeAddress}");

            if (this.ParentFirstName != "" && this.ParentLastName != "")
            {
                Console.WriteLine("Parent Name: ");
            }
            
            if (this.ParentFirstName != "")
            {
                Console.Write(this.ParentFirstName + " ");
            }
            else if (this.ParentLastName != "")
            {
                Console.Write("<unknown> ");
            }

            if (this.ParentLastName != "")
            {
                Console.Write(this.ParentLastName);
            }

            Console.WriteLine("Grades Profile:");
            this.StudentGradeProfile.Display();
            Console.WriteLine("Reports: ");
            foreach (Report report in this.ReportCards)
            {
                report.Display();
            }
        }
    }
}