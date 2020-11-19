using System;

namespace OOPAssignment010T2
{
    public static class OOPUtil
    {
        public static string LongDateToString(long date)
        {
            return new DateTime(date).ToString();
        }

        public static string MarksToGrade(int marks)
        {
            string grade = "Fail";

            if (marks >= 30)
            {
                grade = "Near Pass";
            }

            if (marks >= 40)
            {
                grade = "Pass";
            }

            if (marks >= 60)
            {
                grade = "Merit";
            }

            if (marks >= 70)
            {
                grade = "Distinction";
            }

            return grade;
        }

        public static void WriteThickDivider()
        {
            Console.WriteLine("==============================");
        }

        public static void WriteThinDivider()
        {
            Console.WriteLine("------------------------------");
        }

        public static void WriteIfExists(string obj, string message)
        {
            if (obj != null && obj != "")
            {
                Console.WriteLine(message);
            }
        }
    }
}