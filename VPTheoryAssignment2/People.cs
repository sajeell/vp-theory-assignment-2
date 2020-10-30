using System;
using System.Threading;

namespace VPTheoryAssignment2
{
    public class People
    {
        public void OnCriminalSeen(object source, SeenEventArgs e)
        {
            Console.WriteLine("Report is received by the police!. Now, they will handle it");
        }
    }
}