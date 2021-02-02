using MicroBlessingsApi.Biz.Models.Core;

namespace MicroBlessingsApi.Common
{
    /// <summary>
    /// Represents info necessary to create a blessing
    /// </summary>
    public class CreateBlessingInfo
    {
        /// <summary>
        /// Constructs a creation blessing info object
        /// </summary>
        /// <param name="blessingTypeModelId">The type of blessing</param>
        /// <param name="notes">Any additional notes related to the execution of the blessing</param>
        /// <param name="statusType">The status of the blessing</param>
        public CreateBlessingInfo(ModelId<BlessingType> blessingTypeModelId, string notes, BlessingStatusType statusType)
        {
            BlessingTypeModelId = blessingTypeModelId;
            Notes = notes;
            StatusType = statusType;
        }

        public ModelId<BlessingType> BlessingTypeModelId { get; set; }

        public string Notes { get; set; }

        public BlessingStatusType StatusType { get; set; }
    }
}