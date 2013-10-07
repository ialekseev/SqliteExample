using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;

namespace SmartElk.SqliteExample.Domain.Specs.Install
{
    public class SqliteSessionFactoryCreator
    {       
        public static Configuration Configuration { get; set; }

        public static ISessionFactory CreateFactory(string assemblyName)
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration
                            .Standard.InMemory
                )
                .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.Load(assemblyName))).
                ExposeConfiguration(x =>
                {
                    Configuration = x;
                })
                .BuildSessionFactory();
        }        
    }
}
