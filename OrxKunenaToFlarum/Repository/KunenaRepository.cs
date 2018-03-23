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
    public class KunenaRepository: BaseRepository
    {

        public KunenaRepository()
        {

        }

        public IEnumerable<Category> GetAllCategories()
        {
            List<Category> cats = new List<Category>();
            ICriteria crit = Session.CreateCriteria<Category>();
            //cats = crit.Future<Category>().ToList();
            cats = crit.List<Category>().ToList();

            return cats;
        }

        public IEnumerable<Content> GetAllContent()
        {
            List<Content> content = new List<Content>();
            ICriteria crit = Session.CreateCriteria<Content>();
            content = crit.List<Content>().ToList();

            return content;
        }

        public IEnumerable<Attachment> GetAllAttachments()
        {
            List<Attachment> attachments = new List<Attachment>();
            ICriteria crit = Session.CreateCriteria<Attachment>();
            attachments = crit.List<Attachment>().ToList();

            return attachments;
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            ICriteria crit = Session.CreateCriteria<User>();
            users = crit.List<User>().ToList();

            return users;
        }
    }
}
