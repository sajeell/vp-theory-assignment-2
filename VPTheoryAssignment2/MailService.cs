using System;
using System.Threading;

public class MailService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("MailService: Sending an email...");
        Thread.Sleep(3000);
        Console.WriteLine("Mail sent");
    }
}