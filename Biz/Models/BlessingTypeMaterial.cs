using System;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Represents a material used to help fulfill a blessing
    /// </summary>
    public class BlessingTypeMaterial
    {
        /// <summary>
        /// The unique identifier of a blessing type material
        /// </summary>
        public Guid ModelId { get; set;}

        /// <summary>
        /// The name of the material
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The display name of the material
        /// </summary>
        public string DisplayName { get; set; } 

        /// <summary>
        /// The description of the material
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
    }
}
