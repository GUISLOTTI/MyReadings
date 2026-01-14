namespace MyReadings.Domain.Entities
{
    public class Recommendation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int AutoReviewId { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime ReadAt { get; set; }
        public bool IsRead { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }
        public AutoReview AutoReview { get; set; }
    }
}