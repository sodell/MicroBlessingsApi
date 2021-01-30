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

        public BlessingsDbService()
        {

        }

        public Task<Blessing> CreateBlessing(CreateBlessingInfo createBlessingInfo)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Blessing> GetBlessing(ModelId<Blessing> blessingId)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                var result = await db.QueryAsync<Blessing>(GetQuery, new { blessingId });
                return result.SingleOrDefault();
            }
        }

        public Task<IEnumerable<Blessing>> SearchBlessings(SearchBlessingsCriteria searchBlessingsCriteria)
        {
            throw new System.NotImplementedException();
        }
    }
}