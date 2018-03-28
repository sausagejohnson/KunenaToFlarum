using System;
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
            this.Table("jos_users");
            this.Id(m => m.id);
            this.Map(m => m.name).Column("name");
            this.Map(m => m.username).Column("username");
            this.Map(m => m.email).Column("email");
            this.Map(m => m.password).Column("password");
            this.Map(m => m.usertype).Column("usertype");
            this.Map(m => m.block).Column("block");
            this.Map(m => m.sendEmail).Column("sendEmail");
            this.Map(m => m.gid).Column("gid");
            this.Map(m => m.registerDate).Column("registerDate");
            this.Map(m => m.lastvisitDate).Column("lastvisitDate");
            this.Map(m => m.activation).Column("activation");
            this.References(r => r.userProfile).Column("id").LazyLoad(Laziness.False).NotFound.Ignore(); //{"Unknown column 'this_.user_id' in 'field list'"}
        }

    }
}
