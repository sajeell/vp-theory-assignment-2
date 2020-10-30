using System;
using System.Threading;

namespace VPTheoryAssignment2
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        public EventHandler<VideoEventArgs> VideoEncoded;

        public void encode(Video video)
        {
            Console.WriteLine("Encoding the video...");
            Thread.Sleep(3000);
            Console.WriteLine("Video encoded");

            OnVideoEncoded(video);
        }

        // Raising the event here
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() {Video = video});
            }
        }
    }
}