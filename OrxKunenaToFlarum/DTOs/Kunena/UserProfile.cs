using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrxKunenaToFlarum.DTOs.Kunena
{
    class UserProfile
    {
        int userid;
        string view; // varchar(8) NOT NULL DEFAULT 'flat',
        string signature;
        int moderator;
        int ordering;
        int posts;
        string avatar;
        int karma;
        int karma_time;
        int group_id;
        int uhits;
        string personalText;
        int gender;
        DateTime birthdate;
        string location;
        string ICQ;
        string AIM;
        string YIM;
        string MSN;
        string SKYPE;
        string GTAL;
        string websitename;
        string websiteurl;
        int rank;
        int hideEmail;
        int showOnline;
    }
}

//(62, 'flat', 'Want to follow orx''s development? Go subscribe to the orx-dev group at: [url]https://groups.google.com/forum/?fromgroups#!forum/orx-dev[/url]', 1, 0, 3071, '62.jpg', 71, 1292911141, 1, 313, '', 1, '1978-01-01', 'Montreal', '', '', '', '', '', '', 'Orx - Portable Game Engine', 'orx-project.org', 7, 1, 1),