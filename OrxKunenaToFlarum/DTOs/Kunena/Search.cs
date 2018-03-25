using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrxKunenaToFlarum.DTOs.Kunena
{
    public class Search
    {
        public virtual string search_term { get; set; }
        public virtual int hits { get; set; }
    }
}
