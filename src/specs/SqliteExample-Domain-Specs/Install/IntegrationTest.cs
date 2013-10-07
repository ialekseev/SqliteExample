using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace SmartElk.SqliteExample.Domain.Specs.Install
{
    public class IntegrationTest
    {
        public IntegrationTest()
        {
            Install.RegisterComponents();

            UnitOfWork.DoAfterSessionOpening =
                (sessionScope) =>
                new SchemaExport(SqliteSessionFactoryCreator.Configuration).Execute(false, true, false,
                                                                                    ((ISession)
                                                                                     (sessionScope.InternalSession))
                                                                                        .Connection, null);
        }
    }
}
