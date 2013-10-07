using Castle.MicroKernel.Registration;
using Castle.Windsor;
using CommonServiceLocator.WindsorAdapter;
using Microsoft.Practices.ServiceLocation;
using NHibernate;
using SmartElk.SqliteExample.DataAccess;

namespace SmartElk.SqliteExample.Domain.Specs.Install
{
    public class Install
    {
        private static WindsorContainer Container { get; set; }

        public static void RegisterComponents()
        {
            if (Container == null)
            {
                Container = new WindsorContainer();

                Container.Register(Component.For<ISessionScopeFactory>().ImplementedBy<HibernateSessionScopeFactory>());
                Container.Register(Component.For<ISessionFactory>().Instance(SqliteSessionFactoryCreator.CreateFactory("SmartElk.SqliteExample.DataAccess")).LifeStyle.Singleton);

                ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(Container));
            }            
        }
    }
}
