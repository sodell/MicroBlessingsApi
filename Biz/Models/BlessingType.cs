using System;
using System.Collections.Generic;

namespace MicroBlessingsApi
{
    public class BlessingType
    {
        public Guid ModelId { get; set;}

        public string Name { get; set; }

        public string DisplayName { get; set; } 

        public string Description { get; set; }

        public IEnumerable<BlessingTypeMaterial> Material { get; set; }
    }
}
