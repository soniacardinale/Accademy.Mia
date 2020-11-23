using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
    public class Fax
    {
        private MailManager _mm;

        public Fax(MailManager mm)
        {
            this._mm = mm;
            MailManagerEventHandler del = new MailManagerEventHandler(mm_MailArrived);
            this._mm.MailArrived += del; // invoke add_MailArrived(del);
        }

        public void mm_MailArrived(Object sender, MailEventArgs args)
        {
            Console.WriteLine("I'm a Fax \r\n Mail From: {0} \t\t Mail to: {1} \r\n Subject: {2}\t\t Body: {3}",
                               args.From, args.To, args.Subject, args.Body);
        }
    }
}
