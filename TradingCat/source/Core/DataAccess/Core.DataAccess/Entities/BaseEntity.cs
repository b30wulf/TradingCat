namespace Core.DataAccess.Entities
{
    public abstract class BaseEntity<T> : IEntity
    {
        public T Id { get; set; }
    }
}