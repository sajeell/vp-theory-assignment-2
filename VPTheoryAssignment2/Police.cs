using System;
using System.Threading;

namespace VPTheoryAssignment2
{
    public class SeenEventArgs : EventArgs
    {
        public int TotalThieves { get; set; }
        public int TotalTerrorists { get; set; }
    }

    public class Police
    {
        public EventHandler<SeenEventArgs> CriminalSeen;

        public void report(Record record)
        {
            Console.WriteLine();
            Console.WriteLine("Report is being received by the police....please wait");
            Thread.Sleep(2000);
            Console.WriteLine("Report is successfully received by the police");
            Console.WriteLine();

            OnCriminalSeen(record);
        }

        protected virtual void OnCriminalSeen(Record record)
        {
            if (CriminalSeen != null)
            {
                CriminalSeen(this,
                    new SeenEventArgs()
                    {
                        TotalTerrorists = record.TotalTerrorists,
                        TotalThieves = record.TotalThieves
                    });
            }
        }
    }
}