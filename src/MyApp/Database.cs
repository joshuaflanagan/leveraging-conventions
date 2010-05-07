using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using MyApp.Models;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace MyApp
{
    public class Database 
    {
        public static void BuildSchema()
        {
            new SchemaExport(GetConfiguration()).Create(false, true);
        }

        public static Configuration GetConfiguration()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(x =>
                {
                    x.Database("codecamp2010");
                    x.Server(".");
                    x.TrustedConnection();
                }))
            .Mappings(map => map.AutoMappings.Add(
                AutoMap
                .AssemblyOf<Database>(t => typeof(Entity).IsAssignableFrom(t))
                ))
            .BuildConfiguration();
        }
    }
}