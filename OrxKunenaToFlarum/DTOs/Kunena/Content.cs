using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrxKunenaToFlarum.DTOs.Kunena
{
    /*
     * Content of the news section. Not strictly part of the forum.
     */
    public class Content
    {
        public virtual long id { get; set; }
        public virtual string title { get; set; }
        public virtual string alias { get; set; }
        public virtual string title_alias { get; set; }
        public virtual string introtext { get; set; }
        public virtual string fulltext { get; set; }
        public virtual int state { get; set; }
        public virtual int sectionid { get; set; }
        public virtual int mask { get; set; }
        public virtual int catid { get; set; }
        public virtual DateTime created { get; set; }
        public virtual int created_by { get; set; }
        public virtual string created_by_alias { get; set; }
        public virtual DateTime modified { get; set; }
        public virtual int modified_by { get; set; }
        public virtual int checked_out { get; set; }
        public virtual DateTime checked_out_time { get; set; }
        public virtual DateTime publish_up { get; set; }
        public virtual DateTime publish_down { get; set; }
        public virtual string images { get; set; }
        public virtual string urls { get; set; }
        public virtual string attribs { get; set; }
        public virtual int version { get; set; }
        public virtual int parentid { get; set; }
        public virtual int ordering { get; set; }
        public virtual string metakey { get; set; }
        public virtual string metadesc { get; set; }
        public virtual int access { get; set; }
        public virtual int hits { get; set; }
        public virtual string metadata { get; set; }
    }
}
