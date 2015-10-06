﻿
namespace FunctionalProgramming.Students
{
    using FunctionalProgramming.Students.Enumerations;

    public class XcelStudent : Student
    {
        public int ID { get; internal set; }

        public Gender Gender { get; internal set; }

        public StudentType StudentType { get; set; }

        public int ExamResult { get; set; }

        public int HomeworksSent { get; set; }

        public int HomeworksEvaluated { get; set; }

        public double Teamwork { get; set; }

        public double Attendance { get; set; }

        public double Bonus { get; set; }
    }
}
