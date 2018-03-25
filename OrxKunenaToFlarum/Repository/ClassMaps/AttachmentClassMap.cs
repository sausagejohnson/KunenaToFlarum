﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OrxKunenaToFlarum.DTOs.Kunena;

namespace OrxKunenaToFlarum.Repository.ClassMaps
{
    public class AttachmentClassMap : ClassMap<Attachment>
    {
        public AttachmentClassMap()
        {
            this.Schema("`orxproje_cms`");
            this.Table("jos_fb_attachments");
            this.Id(m => m.mesid);
            this.Map(m => m.filelocation).Column("filelocation");
        }

    }
}
