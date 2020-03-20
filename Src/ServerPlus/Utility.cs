using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerPlus
{
    class Utility
    {
        public static int mail { get; set; }
        public static int mailqueue { get; set; }
        public static int mailfailed { get; set; }
        public static int database { get; set; }
        public static int facial { get; set; }
        public static int text { get; set; }
        public static int Juno_Function { get; set; } = 0;
        public static int Atlas_Function { get; set; } = 0;

        public static int Mail()
        {
            return mail;
        }
        public static int MailFail()
        {
            return mailfailed;
        }
        public static int MailQueue()
        {
            return mailqueue;
        }
        public static int Facial()
        {
            return facial;
        }
        public static int Text()
        {
            return text;
        }
        public static int Database()
        {
            return database;
        }

    }
}
