using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class SearchClassMap : ClassMap<Search>
    {
        public SearchClassMap()
        {
            this.ReadOnly();
            this.Schema("`orx-forum`");
            this.Table("jos_core_log_searches");
            this.Id(m => m.search_term);
            this.Map(m => m.hits).Column("hits");
        }
    }
}
