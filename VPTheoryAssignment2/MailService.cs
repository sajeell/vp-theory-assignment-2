using System;
using System.Threading;
using VPTheoryAssignment2;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        Thread.Sleep(3000);
        Console.WriteLine("Mail sent");
    }
}