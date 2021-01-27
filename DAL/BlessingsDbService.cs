using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using MicroBlessingsApi.Biz.Models.Core;
using System.Threading.Tasks;
using System.Linq;

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

        public async Task<Blessing> GetBlessing(ModelId<Blessing> blessingId)
        {
            using (IDbConnection db = new SqlConnection(""))
            {
                var result = await db.QueryAsync<Blessing>(GetQuery, new { blessingId });
                return result.SingleOrDefault();
            }
        }
    }
}