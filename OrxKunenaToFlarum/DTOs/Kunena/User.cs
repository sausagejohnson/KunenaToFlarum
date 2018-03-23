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
        public virtual string section_value { get; set; }
        public virtual string value { get; set; }
        public virtual int order_value { get; set; }
        public virtual string name { get; set; }
        public virtual int hidden { get; set; }
    }
}

//(10, 'users', '62', 0, 'iarwain', 0),
