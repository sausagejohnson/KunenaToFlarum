using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrxKunenaToFlarum.DTOs.Kunena;
using OrxKunenaToFlarum.Repository;

namespace OrxKunenaToFlarum
{
    class Program
    {
        static void Main(string[] args)
        {
            KunenaRepository repo = new KunenaRepository();
            //repo.GetAllCategories();
            //repo.GetAllContent();
            //repo.GetAllAttachments();
            repo.GetAllUsers();
        }
    }
}


/*
 * Steps:
 * 
 * 1. DTOs to shape the Kunena Data
 * 2. DTOs to shape the Flarum Data
 * 3. Connect with NHibernate / Entity Framework (see which has the cheapest setup and config)
 * 4. Consider filtering options for the messages, link conversion, string conversion.
 * 5. For 4, set up a replacements file for doing group find/replaces.
 * 
 * Running:
 * 1. Install MySQL
 * 2. Import database backup script.
 * 3. Enter params in app.config
 * 4. Add replacements in replacement file
 * 
 * */