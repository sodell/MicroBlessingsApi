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
            WHERE ModelId = @ModelId";

        private readonly string CreateQuery = @"

        ";

        private readonly string SearchQuery = @"

        ";

        public BlessingsDbService()
        {

        }

        public async Task<Blessing> CreateBlessing(CreateBlessingInfo createBlessingInfo)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                return await db.QuerySingleAsync<Blessing>(CreateQuery, new { });
            }
        }

        public async Task<Blessing> GetBlessing(ModelId<Blessing> blessingId)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                return  await db.QuerySingleAsync<Blessing>(GetQuery, new { blessingId });
            }
        }

        public async Task<IEnumerable<Blessing>> SearchBlessings(SearchBlessingsCriteria searchBlessingsCriteria)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                return await db.QueryAsync<Blessing>(SearchQuery, new { });
            }
        }
    }
}