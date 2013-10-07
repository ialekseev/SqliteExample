using SmartElk.SqliteExample.Domain;

namespace SmartElk.SqliteExample.DataAccess
{
    public class HibernateSessionScopeFactory: ISessionScopeFactory
    {
        public ISessionScope Open()
        {            
            return new HibernateSessionScope();
        }
    }
}
