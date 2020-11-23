using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
    public class Printer
    {
        private MailManager _mm;

        public Printer(MailManager mm)
        {
            this._mm = mm;
            this._mm.MailArrived += _mm_MailArrived;
            //1) MailManagerEventHandler del = new MailManagerEventHandler(_mm_MailArrived);
            //2) this._mm.MailArrived += del;
        }

        private void _mm_MailArrived(object sender, MailEventArgs args)
        {
            Console.WriteLine("I'm a Printer \r\n Mail From: {0} \t\t Mail to: {1} \r\n Subject: {2}\t\t Body: {3}",
                               args.From, args.To, args.Subject, args.Body);
        }
    }
}
