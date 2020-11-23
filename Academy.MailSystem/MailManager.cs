using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.MailSystem
{
  
        public class MailManager
        {
            public event MailManagerEventHandler MailArrived;

            public void SimulateMailArrived(string from, string to, string subject, string body)
            {
                MailEventArgs args = new MailEventArgs()
                {
                    Body = body,
                    From = from,
                    Subject = subject,
                    To = to
                };
                #region altri modi di invocare la invocation list
                /*
                // primo metodo
                MailArrived?.Invoke(this, args);


                // secondo metodo
                if (MailArrived != null)
                {
                    MailArrived(this, args);
                }
                */
                #endregion

                // metodo esplicito
                if (MailArrived != null)
                {
                    // Rise Event!!!!!!!!!!
                    foreach (var item in MailArrived.GetInvocationList())
                    {
                        MailManagerEventHandler mm_eh = (MailManagerEventHandler)item;
                        mm_eh(this, args);
                    }
                }

            }
       }
    
}
