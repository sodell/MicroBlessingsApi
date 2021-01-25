using System;
using MicroBlessingsApi.Biz.Models.Core;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Represents a blessing within the micro blessings system
    /// </summary>
    public class Blessing : ModelObject<Blessing>
    {
        public Blessing(ModelId<Blessing> modelId) : base(modelId)
        {
        }

        /// <summary>
        /// The type of blessing
        /// </summary>
        public BlessingType BlessingType { get; set; }

        /// <summary>
        /// Notes that give additional context of the blessing
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// The most recent status of the blessing
        /// </summary>
        public BlessingStatus Status { get; set; }

        /// <summary>
        /// The current version info of the blessing
        /// </summary>
        public VersionInfo VersionInfo { get; set; }
    }
}
