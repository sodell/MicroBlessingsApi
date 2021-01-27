using System;
using System.Threading.Tasks;
using MicroBlessingsApi.Biz.Models.Core;
using MicroBlessingsApi.DAL;

namespace MicroBlessingsApi.Biz.Services
{

    public class BlessingsService : IBlessingsService
    {
        private readonly IBlessingsDbService _blessingsDbService;

        public BlessingsService(IBlessingsDbService blessingsDbService)
        {
            _blessingsDbService = blessingsDbService;
        }

        public async Task<Blessing> GetBlessing(ModelId<Blessing> blessingId)
        {
            try
            {
                return await _blessingsDbService.GetBlessing(blessingId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}