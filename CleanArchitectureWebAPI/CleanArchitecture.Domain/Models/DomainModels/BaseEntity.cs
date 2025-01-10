namespace CleanArchitecture.Domain.Models.DomainModels
{
    public class BaseEntity
    {
        public Guid? Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
