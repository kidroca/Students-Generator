
namespace FunctionalProgramming.Students
{
    class DetailedStudent : Student
    {
        public Gender Gender { get; private set; }

        public StudentType StudentType { get; set; }

        public int ExamResult { get; set; }

        public int HomeworksSent { get; set; }

        public int HomeworksEvaluated { get; set; }

        public double Teamwork { get; set; }

        public double Attendance { get; set; }

        public double Bonus { get; set; }
    }
}
