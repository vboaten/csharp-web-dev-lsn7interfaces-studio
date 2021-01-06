using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            var dvd = new DVD("Jingle Jangle");
            dvd.Content.Add(new Content()
            {
                Title = "Chapter 1",
                Size = 12,
                Data = "this is chapter one.",
                Time = 302
            });
            dvd.MaxRPM = 1600;
            dvd.MinRPM = 570;
            dvd.TotalCapacity = 2400;
            dvd.Type = DvdTypeEnum.BlueRay;

            // TODO: Call each CD and DVD method to verify that they work as expected.
            Console.WriteLine(dvd.Spin());
            Console.WriteLine(dvd.ReportStatus());
            Console.WriteLine($"Remaining Capacity: {dvd.GetRemainingCapacity()}");

            Console.WriteLine("CD: --------------------");

            // TODO: Declare and initialize a CD and a DVD object.
            var cd = new CD("Jingle Jangle");
            cd.Content.Add(new Content()
            {
                Title = "Oops, I Did It Again",
                Size = 6,
                Data = "So many objects.",
                Time = 180
            });
            cd.MaxRPM = 500;
            cd.MinRPM = 200;
            cd.TotalCapacity = 1200;
            cd.Artist = "Kendra";

            // TODO: Call each CD and DVD method to verify that they work as expected.
            Console.WriteLine(cd.Spin());
            Console.WriteLine(cd.ReportStatus());
            Console.WriteLine($"Remaining Capacity: {cd.GetRemainingCapacity()}");

        }
    }
}
