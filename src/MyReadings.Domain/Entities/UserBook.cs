using MyReadings.Domain.Enums;

namespace MyReadings.Domain.Entities
{
    public class UserBook
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public Status Status { get; set; }
        public Decimal Rating { get; set; }
        public string Review { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Book Book { get; set; }

    }
}
