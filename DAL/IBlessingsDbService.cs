using System.Collections.Generic;
using System.Threading.Tasks;
using MicroBlessingsApi.Biz.Models.Core;
using MicroBlessingsApi.Common;

namespace MicroBlessingsApi.DAL
{
    /// <summary>
    /// Data layer service to manage blessigns
    /// </summary>
    public interface IBlessingsDbService
    {
        /// <summary>
        /// Gets the specified blessing
        /// </summary>
        /// <param name="blessingId">The unique identifier of the blessing</param>
        /// <returns>The blessing</returns>
        Task<Blessing> GetBlessing(ModelId<Blessing> blessingId);

        /// <summary>
        /// Creates a blessing based on the specified creation info
        /// </summary>
        /// <param name="createBlessingInfo">The creation info used to create a blessing</param>
        /// <returns>The newly created blessing</returns>
        Task<Blessing> CreateBlessing(CreateBlessingInfo createBlessingInfo);

        /// <summary>
        /// Searches existing blessings based on the provided criteria
        /// </summary>
        /// <param name="searchBlessingsCriteria">The search criteria</param>
        /// <returns>The blessings matching the provided search criteria</returns>
        Task<IEnumerable<Blessing>> SearchBlessings(SearchBlessingsCriteria searchBlessingsCriteria);
    }
}