namespace Industry.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}