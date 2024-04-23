namespace languageLearning.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int LessonId { get; set; } // Foreign key to Lesson table
        public int StudentId { get; set; } // Foreign key to User table (Student)
        public int Rating { get; set; }
        public string Comments { get; set; }
        // Add more properties as needed
    }
}
