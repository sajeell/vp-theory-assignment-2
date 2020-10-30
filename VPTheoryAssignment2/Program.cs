using System;

namespace VPTheoryAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = new Record();
            var police = new Police();
            var people = new People();

            Console.WriteLine();
            Console.WriteLine("01-131182-032");

            int choice;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Press:");
                Console.WriteLine("1. Report Terrorists");
                Console.WriteLine("2. Report Thieves");
                Console.WriteLine();

                choice = int.Parse(Console.ReadLine()!);
                if (choice == 1)
                {
                    Console.WriteLine("Number of terrorists seen:");
                    int numberOfTerrorists = int.Parse(Console.ReadLine()!);
                    police.CriminalSeen += people.OnCriminalSeen;
                    
                    record.TotalTerrorists += numberOfTerrorists;
                    police.report(record);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Number of thieves seen:");
                    int numberOfThieves = int.Parse(Console.ReadLine()!);
                    police.CriminalSeen += people.OnCriminalSeen;
                    
                    record.TotalThieves += numberOfThieves;
                    police.report(record);
                }
            } while (choice != 0);

            Console.WriteLine($"Total thieves seen: {record.TotalThieves}");
            Console.WriteLine($"Total terrorists seen: {record.TotalTerrorists}");
        }
    }
}