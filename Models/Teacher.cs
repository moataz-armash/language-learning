namespace languageLearning.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public int UserId { get; set; } // Foreign key to User table

        // Navigation property
        public User User { get; set; } // The associated user
    }
}
