using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrxKunenaToFlarum.DTOs.Kunena;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using System.Reflection;
using FluentNHibernate.Cfg;
using OrxKunenaToFlarum.Repository.ClassMaps;
using FluentNHibernate.Automapping;

namespace OrxKunenaToFlarum.Repository
{
    public class BaseRepository
    {
        ISessionFactory sessionFactory = null;
        ISession session = null;

        public BaseRepository()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kunenaForum"].ConnectionString;

            AutomappingConfiguration autoConfig = new AutomappingConfiguration();
            TableNameConvention tableNameConvention = new TableNameConvention();

            FluentConfiguration config =
            FluentNHibernate.Cfg.Fluently.Configure().Database(
                    MySQLConfiguration.Standard
                    .ConnectionString(connectionString)
            ).Mappings(m =>
                {
                    m.FluentMappings.Add<CategoryClassMap>(); //( //.AddFromAssembly(classMapAssembly);
                    m.FluentMappings.Add<ContentClassMap>(); 
                    m.FluentMappings.Add<AttachmentClassMap>(); 
                    m.FluentMappings.Add<UserClassMap>();
                    m.FluentMappings.Add<UserProfileClassMap>();
                    m.FluentMappings.Add<SearchClassMap>();
                    m.FluentMappings.Add<MessageClassMap>();
                    m.FluentMappings.Add<MessageTextClassMap>();
                    //m.AutoMappings.Add(
                    //    //AutoMap.AssemblyOf<BaseRepository>(autoConfig).Conventions.Add<TableNameConvention>(tableNameConvention)
                    //    AutoMap.Assembly(Assembly.GetExecutingAssembly(), autoConfig).Conventions.Add<TableNameConvention>(tableNameConvention)
                    //);
                }
            );

            sessionFactory = config.BuildSessionFactory();
            session = sessionFactory.OpenSession();
        }

        public ISession Session
        {
            get
            {
                return session;
            }

            set
            {
                session = value;
            }
        }
    }
}
