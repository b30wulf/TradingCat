namespace Core.Domain.Entities
{
    public abstract class BaseEntity<T> : IEntity where T : struct
    {
        public T Id { get; set; }
    }
}