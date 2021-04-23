using System;
namespace Delegate_Events
{
    public class MessageService
    {
        public void onVideoEncoded(object souce, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text message...."+e.Video.Title);
        }
    }
}
