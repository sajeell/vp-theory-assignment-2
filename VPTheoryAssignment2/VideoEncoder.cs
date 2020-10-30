using System;
using System.Threading;

namespace VPTheoryAssignment2
{
    public class VideoEncoder
    {
        // Defining a delegate here
        public delegate void VideoEncodedEventHandler(object source, EventArgs e);

        // Defining an event here
        public event VideoEncodedEventHandler VideoEncoded;

        public void encode(Video video)
        {
            Console.WriteLine("Encoding the video...");
            Thread.Sleep(3000);
            Console.WriteLine("Video encoded");

            OnVideoEncoded();
        }

        // Raising the event here
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}