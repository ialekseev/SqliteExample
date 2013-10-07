namespace SmartElk.SqliteExample.Domain
{
    public interface ISessionScopeFactory
    {
        ISessionScope Open();
    }
}
