using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrxKunenaToFlarum.DTOs.Kunena
{
    /*
     * Categories of the forum: General, Offtopic, etc
     */
    public class Category
    {
        public virtual int id { get; set; }
        public virtual int parent { get; set; }
        public virtual string name { get; set; }
        public virtual int cat_emoticon { get; set; }
        public virtual int locked { get; set; }
        public virtual int alert_admin { get; set; }
        public virtual int moderated { get; set; }
        public virtual string moderators { get; set; }
        public virtual int pub_access { get; set; }
        public virtual int pub_recurse { get; set; }
        public virtual int admin_access { get; set; }
        public virtual int admin_recurse { get; set; }
        public virtual int ordering { get; set; }
        public virtual int future2 { get; set; }
        public virtual int published { get; set; }
        public virtual int checked_out { get; set; }
        public virtual DateTime checked_out_time { get; set; }
        public virtual int review { get; set; }
        public virtual int hits { get; set; }
        public virtual string description { get; set; }
        public virtual string headerdesc { get; set; }
        public virtual string class_sfx { get; set; }
        public virtual int id_last_msg { get; set; }
        public virtual int numTopics { get; set; }
        public virtual int numPosts { get; set; }
        public virtual int time_last_msg { get; set; }

    }


}

//(12, 11, 'General discussions', 0, 0, 0, 1, NULL, 0, 0, 24, 0, 1, 0, 1, 127, '2014-12-10 12:15:19', 0, 0, 'Talk about anything here... ', '', '', 8539, 233, 1853, 1467083974),