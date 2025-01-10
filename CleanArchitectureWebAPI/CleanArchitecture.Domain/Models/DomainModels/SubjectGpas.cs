namespace CleanArchitecture.Domain.Models.DomainModels
{
    public class SubjectGpas :BaseEntity
    {
        public Guid? Id { get; set; }
        public string? SubjectName { get; set; }
        public double? Gpa { get; set; }
        public string? SubjectPassStatus { get; set; }
        public Guid? StudentId { get; set; }
        public Student? Students { get; set; }
    }
}
