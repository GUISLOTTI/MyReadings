namespace MyReadings.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime BirthDate { get; set;  }
        public string Gender { get; set; }
        public int AgeGroup { get; set; }
        public DateTime CreatedAt  { get; set; }
        public bool IsActive { get; set; }
    }
}
