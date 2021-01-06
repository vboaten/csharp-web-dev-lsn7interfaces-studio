using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public CD(string name) : base(name)
        {

        }

        public string Artist { get; set; }

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
            $"Artist: {Artist}";

            return output;
        }

        public string Spin()
        {
            return $"A CD spins at a rate of {Rate}";
        }

        public void StoreData()
        {
            throw new NotImplementedException();
        }
    }
}
