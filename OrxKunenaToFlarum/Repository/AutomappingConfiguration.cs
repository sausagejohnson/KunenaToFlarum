using FluentNHibernate.Automapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;

/**
 * File not being used. Moving back to manual config.
 */

namespace OrxKunenaToFlarum.Repository
{
    class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            //return type.Namespace == "OrxKunenaToFlarum.DTOs.Kunena";
            return type.FullName == "OrxKunenaToFlarum.DTOs.Kunena.Message" ||
               type.FullName == "OrxKunenaToFlarum.DTOs.Kunena.MessageText" ||
               type.FullName == "OrxKunenaToFlarum.DTOs.Kunena.UserProfile";
            //return type.FullName.Contains("OrxKunenaToFlarum.DTOs.Kunena");
        }

        public override bool IsId(Member member)
        {
            if (member.DeclaringType.Name == "UserProfile")
            {
                return member.Name == "userid";
            }
            return member.Name == "mesid" || member.Name == "id";
        }

    }
}
