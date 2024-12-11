namespace FeedbackService.DTOs
{
    public class FeedbackDTO
    {
        public int ProductId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; } // Rating 0-5
    }
}
