using System;
namespace Delegate_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" };
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService();//subscriber
            var messageService = new MessageService();//subscriber 
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //register a handler for that event
            videoEncoder.VideoEncoded += messageService.onVideoEncoded;//
            videoEncoder.Encode(video);
        }
    }
}
