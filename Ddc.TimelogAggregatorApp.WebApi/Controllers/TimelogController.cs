using Ddc.TimelogAggregatorApp.WebApi.Models;
using Ddc.TimelogAggregatorApp.WebApi.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ddc.TimelogAggregatorApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimelogController : ControllerBase
    {

        private readonly TimelogDbManager Manager;
        private readonly ILogger<TimelogController> _logger;
        public TimelogController(ILogger<TimelogController> logger, TimelogDbManager timelogDbManager)
        {
            Manager = timelogDbManager;

            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Timelog> Get([FromQuery] int limit) => Manager.GetTimelogs(limit);

        [HttpPost]
        public Timelog Post(string eeId, DateTime timestamp)
        {
            Timelog newTimelog = new();
            try
            {
                Timelog latestTimelog = Manager.GetLastTimelog(eeId);

                newTimelog.EEId = eeId;
                newTimelog.Timestamp = timestamp;
                newTimelog.Status = latestTimelog.GetNextLogStatus(timestamp);
                newTimelog.LogDate = latestTimelog.GetNextLogDate(timestamp, newTimelog.Status);

                Manager.SaveTimelog(newTimelog);

                return newTimelog;
            }
            catch (Exception ex) { BadRequest(ex); }
            return newTimelog;
        }

    }
}
