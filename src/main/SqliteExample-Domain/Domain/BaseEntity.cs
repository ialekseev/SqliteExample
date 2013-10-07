namespace SmartElk.SqliteExample.Domain.Domain
{
    public class BaseEntity<TId>
    {
        public virtual TId Id { get; set; }
    }
}
