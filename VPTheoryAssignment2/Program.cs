using System;
using System.Threading;

namespace VPTheoryAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.encode(video);
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
            Thread.Sleep(3000);
        }
    }
}