using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrxKunenaToFlarum.DTOs.Kunena
{
    public class Message
    {
        public virtual int id { get; set; }
        public virtual int parent { get; set; }
        public virtual int thread { get; set; }
        public virtual int catid { get; set; }
        public virtual string name { get; set; }
        public virtual int userid { get; set; }
        public virtual string email { get; set; }
        public virtual string subject { get; set; }
        public virtual int time { get; set; }
        public virtual string ip { get; set; }
        public virtual int topic_emoticon { get; set; }
        public virtual int locked { get; set; }
        public virtual int hold { get; set; }
        public virtual int ordering { get; set; }
        public virtual int hits { get; set; }
        public virtual int moved { get; set; }
        public virtual int modified_by { get; set; }
        public virtual int modified_time { get; set; }
        public virtual string modified_reason { get; set; }
    }
}

//(3, 0, 3, 13, 'Loops', 63, 'jlloubes@gmail.com', 'ASteroid ReduX', 1219510998, '72.0.207.250', 1, 0, 0, 0, 1211, 0, 63, 1237590117, 'project space created =)'),