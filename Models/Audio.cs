namespace languageLearning.Models
{
    public class Audio
    {
        public int AudioId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public int TeacherId { get; set; } // Foreign key to Teacher table

        // Navigation property
        public Teacher Teacher { get; set; } // The teacher who uploaded the audio
    }
}
