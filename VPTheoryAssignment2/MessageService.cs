using System;
using System.Threading;

namespace VPTheoryAssignment2
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending a text messaage..." + e.Video.Title);
            Thread.Sleep(2000);
            Console.WriteLine("Message sent");
        }
    }
}