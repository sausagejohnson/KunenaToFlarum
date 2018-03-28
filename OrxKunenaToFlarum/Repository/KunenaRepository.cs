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
            users = crit.List<User>().Where(m=>m.id == 473).ToList();

            return users;
        }

        public IEnumerable<User> GetAllUsersWithoutAProfile()
        {
            List<User> users = new List<User>();
            ICriteria crit = Session.CreateCriteria<User>();
            users = crit.List<User>().Where(m => m.userProfile == null).ToList();

            return users;
        }

        public IEnumerable<Message> GetAllMessages()
        {
            List<Message> messages = new List<Message>();
            ICriteria crit = Session.CreateCriteria<Message>();
            messages = crit.List<Message>().ToList();

            return messages;
        }

        public IEnumerable<Message> GetAllMessagesWithoutAUserProfile()
        {
            List<Message> messages = new List<Message>();
            ICriteria crit = Session.CreateCriteria<Message>();
            messages = crit.List<Message>().Where(m=>m.userProfile == null).ToList();

            return messages;
        }

        public IEnumerable<Message> GetAllMessagesWithoutMessageText()
        {
            List<Message> messages = new List<Message>();
            ICriteria crit = Session.CreateCriteria<Message>();
            messages = crit.List<Message>().Where(m => m.messageText == null).ToList();

            return messages;
        }

        

        public IEnumerable<Message> GetAllMessagesWithAUserProfileButWithoutAUser()
        {
            List<Message> messages = new List<Message>();
            ICriteria crit = Session.CreateCriteria<Message>();
            messages = crit.List<Message>().Where(m => m.userProfile.user == null).ToList();

            messages.ForEach(m => Console.WriteLine("name: {0}, name: {1}", m.name, m.email));

            return messages;
        }

        public IEnumerable<MessageText> GetAllMessageTexts()
        {
            List<MessageText> messageTexts = new List<MessageText>();
            ICriteria crit = Session.CreateCriteria<MessageText>();
            messageTexts = crit.List<MessageText>().ToList();

            return messageTexts;
        }

        public IEnumerable<Search> GetAllSearches()
        {
            List<Search> searches = new List<Search>();
            ICriteria crit = Session.CreateCriteria<Search>();
            searches = crit.List<Search>().ToList();

            return searches;
        }

        public IEnumerable<UserProfile> GetAllUserProfiles()
        {
            List<UserProfile> userProfiles = new List<UserProfile>();
            ICriteria crit = Session.CreateCriteria<UserProfile>();
            userProfiles = crit.List<UserProfile>().ToList();

            return userProfiles;
        }

        public IEnumerable<User> UserToTest()
        {
            List<User> users = new List<User>();
            ICriteria crit = Session.CreateCriteria<User>();
            users = crit.List<User>().Where(u=>u.id == 473).ToList();

            return users;
        }

        public IEnumerable<UserProfile> UserProfileToTest()
        {
            List<UserProfile> userProfiles = new List<UserProfile>();
            ICriteria crit = Session.CreateCriteria<UserProfile>();
            userProfiles = crit.List<UserProfile>().Where(u=>u.userid == 473).ToList();

            return userProfiles;
        }

    }
}
