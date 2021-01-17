using System;

namespace MicroBlessingsApi
{
    public class Blessing 
    {
        public Guid ModelId { get; set;}

        public BlessingType BlessingType { get; set; }

        public string Notes { get; set; }
    }
}
