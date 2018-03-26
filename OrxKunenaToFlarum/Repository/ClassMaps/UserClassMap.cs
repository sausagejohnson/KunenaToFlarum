﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class UserClassMap : ClassMap<User>
    {
        public UserClassMap()
        {
            this.Schema("`orx-forum`");
            this.Table("jos_core_acl_aro");
            this.Id(m => m.id);
            this.Map(m => m.section_value).Column("section_value");
            this.Map(m => m.value).Column("value"); //this is the reference to the UserProfile ID
            this.Map(m => m.name).Column("name");
            this.Map(m => m.hidden).Column("hidden");
            this.References(r => r.userProfile).Column("value").LazyLoad(Laziness.False).NotFound.Ignore(); //{"Unknown column 'this_.user_id' in 'field list'"}
        }

    }
}
