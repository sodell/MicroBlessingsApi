using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroBlessingsApi.Controllers
{
    [ApiController]
    [Route("blessings")]
    public class BlessingsController : ControllerBase
    {

        private readonly ILogger<BlessingsController> _logger;

        public BlessingsController(ILogger<BlessingsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Blessing> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Blessing
            {
                ModelId = Guid.NewGuid(),
                BlessingType = new BlessingType {
                     ModelId = Guid.NewGuid(),
                     Name = "BasketballNet",
                     DisplayName = "Basketball Net",
                     Description = "Description"
                }
            })
            .ToArray();
        }
    }
}
