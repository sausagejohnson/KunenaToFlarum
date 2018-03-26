using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class MessageTextClassMap : ClassMap<MessageText>
    {
        public MessageTextClassMap()
        {
            this.Schema("`orx-forum`");
            this.Table("jos_fb_messages_text");
            this.Id(m => m.mesid);
            this.Map(m => m.message).Column("message");
        }
    }
}
