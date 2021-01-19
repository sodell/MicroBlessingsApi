using System;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Represents version info for a model
    /// </summary>
    public class VersionInfo
    {
        /// <summary>
        /// The current version of the model
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        /// Who the model was versioned by
        /// </summary>
        public string VersionBy { get; set; }

        /// <summary>
        /// When the model was versioned
        /// </summary>
        public DateTimeOffset VersionOn { get; set; }
    }
}