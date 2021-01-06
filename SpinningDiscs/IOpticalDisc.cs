namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public string Spin();
        public void StoreData();
        public string ReportStatus();
        public void ReadData();
        public double GetRemainingCapacity();
    }
}
