using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class UserProfileClassMap : ClassMap<UserProfile>
    {
        public UserProfileClassMap()
        {
            this.Schema("`orx-forum`");
            this.Table("jos_fb_users");
            this.Id(m => m.userid);
            this.Map(m => m.view).Column("view");
            this.Map(m => m.signature).Column("signature");
            this.Map(m => m.moderator).Column("moderator");
            this.Map(m => m.ordering).Column("ordering");
            this.Map(m => m.posts).Column("posts");
            this.Map(m => m.avatar).Column("avatar");
            this.Map(m => m.karma).Column("karma");
            this.Map(m => m.karma_time).Column("karma_time");
            this.Map(m => m.group_id).Column("group_id");
            this.Map(m => m.uhits).Column("uhits");
            this.Map(m => m.personalText).Column("personalText");
            this.Map(m => m.gender).Column("gender");
            this.Map(m => m.birthdate).Column("birthdate");
            this.Map(m => m.location).Column("location");
            this.Map(m => m.ICQ).Column("ICQ");
            this.Map(m => m.AIM).Column("AIM");
            this.Map(m => m.YIM).Column("YIM");
            this.Map(m => m.MSN).Column("MSN");
            this.Map(m => m.SKYPE).Column("SKYPE");
            this.Map(m => m.GTALK).Column("GTALK");
            this.Map(m => m.websitename).Column("websitename");
            this.Map(m => m.websiteurl).Column("websiteurl");
            this.Map(m => m.rank).Column("rank");
            this.Map(m => m.hideEmail).Column("hideEmail");
            this.Map(m => m.showOnline).Column("showOnline");
            this.References(r => r.user).Column("userid").LazyLoad(Laziness.False).NotFound.Ignore(); // Hmm.... missing records here. Find them later.
        }
    }
}

//	62	flat	Want to follow orx's development? Go subscribe to the orx-dev group at: [url]https://groups.google.com/forum/?fromgroups#!forum/orx-dev[/url]	1	0	3071	62.jpg	71	1292911141	1	313		1	1978-01-01	Montreal							Orx - Portable Game Engine	orx-project.org	7	1	1