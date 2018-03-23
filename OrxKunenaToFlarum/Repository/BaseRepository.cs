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

namespace OrxKunenaToFlarum.Repository
{
    public class BaseRepository
    {
        ISessionFactory sessionFactory = null;
        ISession session = null;

        public BaseRepository()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["kunenaForum"].ConnectionString;

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
