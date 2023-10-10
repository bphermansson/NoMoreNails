using System;
using System.Diagnostics;

namespace NoMoreNails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Nail> fingerNail = new List<Nail>();
            List<Nail> toeNail = new List<Nail>();

            Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                double initialLength = (random.NextDouble() * 0.5 + 0.1);
                fingerNail.Add(new FingerNail("Finger " + (i ), initialLength, true, false));
                toeNail.Add(new ToeNail("Toe " + (i), initialLength, false, true));
            }

            for (int day = 1; day <= 7; day++)
            {
                Console.WriteLine("Dag " + day + ":");
                foreach (var nail in fingerNail)
                {
                    nail.Grow(0.1);
                    nail.Clip();
                    Console.WriteLine($"{nail.FingerOrToe} - Längd: {nail.Length:F1}mm, Målad: {nail.IsPainted}, Vitaminbrist: {nail.HasVitaminDeficiency}");
                }
                foreach (var nail in toeNail)
                {
                    nail.Grow(random.NextDouble() * 0.5 + 0.1);
                    nail.Clip();
                    Console.WriteLine($"{nail.FingerOrToe} - Längd: {nail.Length:F1}mm, Målad: {nail.IsPainted}, Vitaminbrist: {nail.HasVitaminDeficiency}");
                }
            }
        }
    }
}