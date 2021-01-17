﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MicroBlessingsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlessingsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

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
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
