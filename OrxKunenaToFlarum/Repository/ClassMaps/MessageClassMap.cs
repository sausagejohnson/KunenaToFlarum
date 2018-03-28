using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    class MessageClassMap : ClassMap<Message>
    {
        public MessageClassMap()
        {
            this.Schema("`orx-forum`");
            this.Table("jos_fb_messages");
            this.Id(m => m.id);
            this.Map(m => m.parent).Column("parent");
            this.Map(m => m.thread).Column("thread");
            this.Map(m => m.catid).Column("catid");
            this.Map(m => m.name).Column("name");
            this.Map(m => m.userid).Column("userid");
            this.Map(m => m.email).Column("email");
            this.Map(m => m.subject).Column("subject");
            this.Map(m => m.time).Column("time");
            this.Map(m => m.ip).Column("ip");
            this.Map(m => m.topic_emoticon).Column("topic_emoticon");
            this.Map(m => m.locked).Column("locked");
            this.Map(m => m.hold).Column("hold");
            this.Map(m => m.ordering).Column("ordering");
            this.Map(m => m.hits).Column("hits");
            this.Map(m => m.moved).Column("moved");
            this.Map(m => m.modified_by).Column("modified_by");
            this.Map(m => m.modified_time).Column("modified_time");
            this.Map(m => m.modified_reason).Column("modified_reason");
            this.References(r => r.userProfile).Column("userid").LazyLoad(Laziness.False).NotFound.Ignore(); // Hmm.... missing records here. Find them later.
            this.References(r => r.messageText).Column("id").LazyLoad(Laziness.False).NotFound.Ignore(); // Test for missing records
        }

    }
}
