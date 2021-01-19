using System;
using System.Collections.Generic;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Represents a blessing type
    /// </summary>
    public class BlessingType
    {
        /// <summary>
        /// The unique identifier of a blessing type
        /// </summary>
        public Guid ModelId { get; set;}

        /// <summary>
        /// The name of a blessing type
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// THe display name of a blessing type
        /// </summary>
        public string DisplayName { get; set; } 

        /// <summary>
        /// The description of a blessing type
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        /// <summary>
        /// The material used to help fulfill a blessing
        /// </summary>
        public IEnumerable<BlessingTypeMaterial> Material { get; set; }
    }
}
