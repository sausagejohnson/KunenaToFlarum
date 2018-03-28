using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrxKunenaToFlarum.DTOs.Kunena
{
    public class UserProfile
    {
        public virtual int userid { get; set; }
        public virtual User user { get; set; }
        public virtual string view { get; set; }
        public virtual string signature { get; set; }
        public virtual int moderator { get; set; }
        public virtual int ordering { get; set; }
        public virtual int posts { get; set; }
        public virtual string avatar { get; set; }
        public virtual int karma { get; set; }
        public virtual int karma_time { get; set; }
        public virtual int group_id { get; set; }
        public virtual int uhits { get; set; }
        public virtual string personalText { get; set; }
        public virtual int gender { get; set; }
        public virtual DateTime birthdate { get; set; }
        public virtual string location { get; set; }
        public virtual string ICQ { get; set; }
        public virtual string AIM { get; set; }
        public virtual string YIM { get; set; }
        public virtual string MSN { get; set; }
        public virtual string SKYPE { get; set; }
        public virtual string GTALK { get; set; }
        public virtual string websitename { get; set; }
        public virtual string websiteurl { get; set; }
        public virtual int rank { get; set; }
        public virtual int hideEmail { get; set; }
        public virtual int showOnline { get; set; }
    }
}

//(62, 'flat', 'Want to follow orx''s development? Go subscribe to the orx-dev group at: [url]https://groups.google.com/forum/?fromgroups#!forum/orx-dev[/url]', 1, 0, 3071, '62.jpg', 71, 1292911141, 1, 313, '', 1, '1978-01-01', 'Montreal', '', '', '', '', '', '', 'Orx - Portable Game Engine', 'orx-project.org', 7, 1, 1),