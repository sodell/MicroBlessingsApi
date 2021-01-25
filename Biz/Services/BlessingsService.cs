using System;
using MicroBlessingsApi.Biz.Models.Core;
using MicroBlessingsApi.DAL;

namespace MicroBlessingsApi.Biz.Services
{
    public class BlessingsService
    {
        private readonly IBlessingsDbService _blessingsDbService;

        public BlessingsService(IBlessingsDbService blessingsDbService)
        {
            _blessingsDbService = blessingsDbService;
        }

        public Blessing GetBlessing(ModelId<Blessing> blessingId)
        {
            try
            {
                return _blessingsDbService.GetBlessing(blessingId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}