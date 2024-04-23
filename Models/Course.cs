namespace languageLearning.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int TeacherId { get; set; } // Foreign key to Teacher table

        public Teacher Teacher { get; set; }
    }
}
