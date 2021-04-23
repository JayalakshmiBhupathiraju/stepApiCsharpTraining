using System;

namespace Delegate_Events
{
    public class MailService
    {
        public void OnVideoEncoded(object souce,VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending an email..."+e.Video.Title);
        }
    }
}
