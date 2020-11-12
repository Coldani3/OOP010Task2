using System;

namespace OOPAssignment010T2
{
    public class Assignment
    {
        public int AssignmentNo;
        public string AssignmentID;
        public DateTime DateDue;
        public DateTime DateSet { get; private set; }

        public Assignment(int assignmentNo, string assignmentID, DateTime dateSet, DateTime dateDue)
        {
            this.AssignmentNo = assignmentNo;
            this.AssignmentID = assignmentID;
            this.DateSet = dateSet;
            this.DateDue = dateDue;
        }

        public string GetHumanReadableDateSet()
        {
            return this.DateSet.ToString();
        }

        public string GetHumanReadableDateDue()
        {
            return this.DateDue.ToString();
        }
    }
}