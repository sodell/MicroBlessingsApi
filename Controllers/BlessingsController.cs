using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroBlessingsApi.Biz.Models.Core;
using MicroBlessingsApi.Biz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroBlessingsApi.Controllers
{
    [ApiController]
    [Route("blessings")]
    public class BlessingsController : ControllerBase
    {

        private readonly IBlessingsService _blessingsService;
        private readonly ILogger<BlessingsController> _logger;

        public BlessingsController(IBlessingsService blessingsService, ILogger<BlessingsController> logger)
        {
            _blessingsService = blessingsService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<Blessing> Get([FromRoute] Guid blessingId)
        {
            var blessingModelId = new ModelId<Blessing>(blessingId, 0);
            return await _blessingsService.GetBlessing(blessingModelId);
        }
    }
}
