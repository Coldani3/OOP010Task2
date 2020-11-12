﻿using System;
using System.Collections.Generic;

namespace OOPAssignment010T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment(2, "011", DateTime.Now, DateTime.Now.AddDays(7));
            Assignment assignment2 = new Assignment(1, "010", DateTime.Now, DateTime.Now.AddDays(7));
            Module module = new Module("Object Oriented Programming", "MOD005437", new Assignment[] { assignment });
            Grade grade = new Grade(72, 0.7f, module, assignment);
            Grade grade2 = new Grade(40, 0.3f, module, assignment2);
            GradeProfile profile = new GradeProfile();
            profile.AddGrades(module, new List<Grade>() {grade, grade2});
            profile.Display();
        }
    }
}
