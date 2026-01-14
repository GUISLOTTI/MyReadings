using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyReadings.Domain.Entities
{
    public class AutoReview
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AgeGroup { get; set; }
        public string Summary { get; set; }
        public decimal AverageRating { get; set; }
        public int ReadCount { get; set; }
        public DateTime GeneratedAt { get; set; }
        public bool IsActive { get; set; }

        public Book Book { get; set; }
    }
}