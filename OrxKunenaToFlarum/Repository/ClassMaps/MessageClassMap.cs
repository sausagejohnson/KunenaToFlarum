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
            this.Schema("`orxproje_cms`");
            //this.Table("jos_fb_messages");
            //this.Id(m => m.id);
            //this.Map(m => m.section_value).Column("section_value");
        }

    }
}
