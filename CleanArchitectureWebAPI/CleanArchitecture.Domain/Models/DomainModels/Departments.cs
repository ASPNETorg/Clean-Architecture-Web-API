namespace CleanArchitecture.Domain.Models.DomainModels
{
    public class Departments : BaseEntity
    {
        public Guid? Id { get; set; }
        public string? DepartmentName { get; set; }
        public Guid? StudentId { get; set; }
        public Student? Students { get; set; }
    }
}
