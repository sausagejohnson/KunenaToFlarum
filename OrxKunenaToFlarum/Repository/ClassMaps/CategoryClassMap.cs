using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class CategoryClassMap : ClassMap<Category>
    {
        public CategoryClassMap(){
            this.Schema("`orxproje_cms`");
            this.Table("jos_fb_categories");
            this.Id(m => m.id);
            this.Map(m => m.parent).Column("parent");
            this.Map(m => m.name).Column("name");
            this.Map(m => m.cat_emoticon).Column("cat_emoticon");
            this.Map(m => m.locked).Column("locked");
            this.Map(m => m.alert_admin).Column("alert_admin");
            this.Map(m => m.moderated).Column("moderated");
            this.Map(m => m.moderators).Column("moderators");
            this.Map(m => m.pub_access).Column("pub_access");
            this.Map(m => m.pub_recurse).Column("pub_recurse");
            this.Map(m => m.admin_access).Column("admin_access");
            this.Map(m => m.admin_recurse).Column("admin_recurse");
            this.Map(m => m.ordering).Column("ordering");
            this.Map(m => m.future2).Column("future2");
            this.Map(m => m.published).Column("published");
            this.Map(m => m.checked_out).Column("checked_out");
            this.Map(m => m.checked_out_time).Column("checked_out_time");
            this.Map(m => m.hits).Column("hits");
            this.Map(m => m.description).Column("description");
            this.Map(m => m.headerdesc).Column("headerdesc");
            this.Map(m => m.class_sfx).Column("class_sfx");
            this.Map(m => m.id_last_msg).Column("id_last_msg");
            this.Map(m => m.numTopics).Column("numTopics");
            this.Map(m => m.numPosts).Column("numPosts");
            this.Map(m => m.time_last_msg).Column("time_last_msg");
            //this.References<Content>(c => c.).ForeignKey("catid");
        }

    }
}
