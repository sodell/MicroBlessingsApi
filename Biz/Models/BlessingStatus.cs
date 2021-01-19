using System;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Represents a given status for the blessing
    /// </summary>
    public class BlessingStatus
    {
        /// <summary>
        /// The unique identifier of the blessing status
        /// </summary>
        public Guid ModelId { get; set;}

        /// <summary>
        /// The status type of the blessing status
        /// </summary>
        public BlessingStatusType StatusType { get; set; }

        /// <summary>
        /// Created by and on for the blessing status
        /// </summary>
        public CreatedInfo CreatedInfo { get; set; }
    }
}
