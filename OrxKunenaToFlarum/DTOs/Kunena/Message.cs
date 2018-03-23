using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrxKunenaToFlarum.DTOs.Kunena
{
    class Message
    {
        int id;
        int parent;
        int thread;
        int catid;
        string name;
        int userid;
        string email;
        string subject;
        int time;
        string ip;
        int topic_emoticon;
        int locked;
        int hold;
        int ordering;
        int hits;
        int moved;
        int modified_by;
        int modified_time;
        string modified_reason;
    }
}

//(3, 0, 3, 13, 'Loops', 63, 'jlloubes@gmail.com', 'ASteroid ReduX', 1219510998, '72.0.207.250', 1, 0, 0, 0, 1211, 0, 63, 1237590117, 'project space created =)'),