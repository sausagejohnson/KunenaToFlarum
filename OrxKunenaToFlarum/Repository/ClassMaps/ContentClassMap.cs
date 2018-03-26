using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class ContentClassMap : ClassMap<Content>
    {
        public ContentClassMap()
        {
            this.Schema("`orx-forum`");
            this.Table("jos_content");
            this.Id(m => m.id);
            this.Map(m => m.title).Column("title");
            this.Map(m => m.alias).Column("alias");
            this.Map(m => m.title_alias).Column("title_alias");
            this.Map(m => m.introtext).Column("introtext");
            this.Map(m => m.fulltext).Column("fulltext");
            this.Map(m => m.state).Column("state");
            this.Map(m => m.sectionid).Column("sectionid");
            this.Map(m => m.mask).Column("mask");
            this.Map(m => m.catid).Column("catid");
            this.Map(m => m.created).Column("created");
            this.Map(m => m.created_by).Column("created_by");
            this.Map(m => m.created_by_alias).Column("created_by_alias");
            this.Map(m => m.modified).Column("modified");
            this.Map(m => m.modified_by).Column("modified_by");
            this.Map(m => m.checked_out).Column("checked_out");
            this.Map(m => m.checked_out_time).Column("checked_out_time");
            this.Map(m => m.publish_up).Column("publish_up");
            this.Map(m => m.publish_down).Column("publish_down");
            this.Map(m => m.images).Column("images");
            this.Map(m => m.urls).Column("urls");
            this.Map(m => m.attribs).Column("attribs");
            this.Map(m => m.version).Column("version");
            this.Map(m => m.parentid).Column("parentid");
            this.Map(m => m.ordering).Column("ordering");
            this.Map(m => m.metakey).Column("metakey");
            this.Map(m => m.metadesc).Column("metadesc");
            this.Map(m => m.access).Column("access");
            this.Map(m => m.hits).Column("hits");
            this.Map(m => m.metadata).Column("metadata");
        }
    }
}
