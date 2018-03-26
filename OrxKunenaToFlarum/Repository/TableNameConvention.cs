using FluentNHibernate.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Instances;

/**
 * File not being used. Moving back to manual config.
 */

namespace OrxKunenaToFlarum.Repository
{
    public class TableNameConvention : IClassConvention
    {
        public void Apply(IClassInstance instance)
        {
            if (instance.EntityType.Name == "Message")
            {
                instance.Table("jos_fb_messages");
            }

            if (instance.EntityType.Name == "MessageText")
            {
                instance.Table("jos_fb_messages_text");
            }

            if (instance.EntityType.Name == "UserProfile")
            {
                instance.Table("jos_fb_users");
            }
        }
    }
}
