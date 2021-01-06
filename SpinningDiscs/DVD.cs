using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DvdTypeEnum Type { get; set; }

        public DVD(string name) : base(name)
        {

        }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public double GetRemainingCapacity()
        {
            return TotalCapacity - UsedCapacity;
        }

        public void ReadData()
        {
            throw new NotImplementedException();
        }

        public string ReportStatus()
        {
            string output = $"Name: {Name} {Environment.NewLine}" +
                $"Total: {TotalCapacity} {Environment.NewLine}" +
                $"Min RPM: {MinRPM} {Environment.NewLine}" +
                $"Type: {Type} {Environment.NewLine}";

            return output;
        }

        public string Spin()
        {
            return $"A DVD spins at a rate of {Rate}";
        }

        public void StoreData()
        {
            throw new NotImplementedException();
        }
    }

    public enum DvdTypeEnum
    {
        BlueRay,
        HD,
        Standard,
        WideScreen
    }
}

