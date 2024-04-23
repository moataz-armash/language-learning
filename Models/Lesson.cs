namespace languageLearning.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AudioId { get; set; } // Foreign key to Audio table
        public int TeacherId { get; set; } // Foreign key to Teacher table

        // Navigation properties
        public Audio Audio { get; set; }
        public Teacher Teacher { get; set; } // The teacher who created the lesson
    }
}
