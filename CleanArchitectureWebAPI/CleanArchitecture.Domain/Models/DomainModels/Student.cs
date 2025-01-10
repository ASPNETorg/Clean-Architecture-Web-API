using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models.DomainModels
{
    public class Student :BaseEntity
    {
        [Key]
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Emial { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
