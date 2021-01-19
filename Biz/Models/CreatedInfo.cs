using System;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Represents creation info for a model
    /// </summary>
    public class CreatedInfo
    {
        /// <summary>
        /// Who the model was created by
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// When the model was created
        /// </summary>
        public DateTimeOffset CreatedOn { get; set; }
    }
}