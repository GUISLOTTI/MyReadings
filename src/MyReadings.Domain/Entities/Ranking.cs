using MyReadings.Domain.Enums;

namespace MyReadings.Domain.Entities
{
    public class Ranking
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AgeGroup { get; set; }
        public Period Period { get; set; }
        public int RankPosition { get; set; }
        public int ReadCount { get; set; }
        public decimal AverageRating { get; set; }
        public DateTime PeriodDate { get; set; }

    }
}