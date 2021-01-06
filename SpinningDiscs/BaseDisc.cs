using System.Collections.Generic;
using System.Linq;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public BaseDisc(string name)
        {
            Name = name;
            Content = new List<Content>();
        }
        public string Name { get; set; }
        public double TotalCapacity { get; set; }
        public List<Content> Content { get; set; }
        public int MinRPM { get; set; }
        public int MaxRPM { get; set; }
        public string Rate
        {
            get
            {
                return $"{MinRPM} - {MaxRPM}";
            }
        }
        public int UsedCapacity
        {
            get
            {
                var sum = 0;
                foreach (var track in Content)
                {
                    sum = sum + track.Size;
                }
                return sum;

                //return Content.Sum(x => x.Size);
            }
        }
    }

    public class Content
    {
        public string Title { get; set; }
        public int Time { get; set; }
        public int Size { get; set; }
        public string Data { get; set; }
    }
}
