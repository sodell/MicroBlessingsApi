using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using MicroBlessingsApi.Biz.Models.Core;
using System.Threading.Tasks;
using System.Linq;
using MicroBlessingsApi.Common;
using System.Collections.Generic;

namespace MicroBlessingsApi.DAL
{
    public class BlessingsDbService : IBlessingsDbService
    {
        private readonly string GetQuery = @"
            SELECT * FROM Blessing
            WHERE ModelId = @ModelId;";

        private readonly string CreateQuery = @"
            INSERT INTO Blessing
            (blessing_type_model_id, notes, status_type_id)
            VALUES
            (@BlessingTypeModelId, @Notes, @StatusTypeId);
        ";

        private readonly string SearchQuery = @"
            SELECT * FROM Blessing
            WHERE (@StatusTypeId IS NULL || (@StatusTypeId IS NOT NULL && @StatusTypeId = StatusTypeId))
              AND (@BlessingTypeModelId IS NULL || (@BlessingTypeModelId IS NOT NULL && @BlessingTypeModelId = BlessingTypeModelId));
        ";

        public BlessingsDbService()
        {

        }

        public async Task<Blessing> CreateBlessing(CreateBlessingInfo createBlessingInfo)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                return await db.QuerySingleAsync<Blessing>(CreateQuery, new {
                    BlessingTypeModelId = createBlessingInfo.BlessingTypeModelId,
                    Notes = createBlessingInfo.Notes,
                    StatusTypeId = createBlessingInfo.StatusType });
            }
        }

        public async Task<Blessing> GetBlessing(ModelId<Blessing> blessingId)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                return  await db.QuerySingleAsync<Blessing>(GetQuery, new { ModelId = blessingId });
            }
        }

        public async Task<IEnumerable<Blessing>> SearchBlessings(SearchBlessingsCriteria searchBlessingsCriteria)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                return await db.QueryAsync<Blessing>(SearchQuery, new {
                    BlessingTypeModelId = searchBlessingsCriteria.BlessingTypeModelId,
                    StatusTypeId = searchBlessingsCriteria.StatusType });
            }
        }
    }
}