namespace Delegate.Models
{
    class Exam
    {
        public string Subject;
        public int ExamDuration;
        public DateTime StartDate;
        public DateTime EndDate;

        public Exam(string subject, int duration, DateTime start)
        {
            Subject = subject;
            ExamDuration = duration;
            StartDate = start;
            EndDate = StartDate.AddHours(ExamDuration);
        }
    }
}
