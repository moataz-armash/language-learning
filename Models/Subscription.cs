namespace languageLearning.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int StudentId { get; set; } // Foreign key to User table (Student)
        public int LessonId { get; set; } // Foreign key to Lesson table
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SubscriptionType { get; set; }
        // Add more properties as needed
    }
}
