using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrxKunenaToFlarum.DTOs.Kunena
{
    public class User
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual string username { get; set; }
        public virtual UserProfile userProfile { get; set; }
        public virtual string email { get; set; }
        public virtual string password { get; set; }
        public virtual string usertype { get; set; }
        public virtual int block { get; set; }
        public virtual int sendEmail { get; set; }
        public virtual int gid { get; set; }
        public virtual DateTime registerDate { get; set; }
        public virtual DateTime lastvisitDate { get; set; }
        public virtual string activation { get; set; }
        //public virtual string params { get; set; } //reserved word
    }
}

//(10, 'users', '62', 0, 'iarwain', 0),
