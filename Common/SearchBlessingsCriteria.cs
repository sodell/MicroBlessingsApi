using MicroBlessingsApi.Biz.Models.Core;

namespace MicroBlessingsApi.Common
{
    public class SearchBlessingsCriteria
    {
        /// <summary>
        /// Constructs a search blessings criteria object
        /// </summary>
        /// <param name="blessingTypeModelId">The type of blessing</param>
        /// <param name="statusType">The status of the blessing</param>
        public SearchBlessingsCriteria(ModelId<BlessingType> blessingTypeModelId, BlessingStatusType statusType)
        {
            BlessingTypeModelId = blessingTypeModelId;
            StatusType = statusType;
        }

        public ModelId<BlessingType> BlessingTypeModelId { get; set; }

        public BlessingStatusType StatusType { get; set; }
    }
}