using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace TotalmediaPOCApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StartController : ControllerBase
    {
        #region Core

        private readonly ILogger<StartController> logger;

        public StartController(ILogger<StartController> logger)
        {
            this.logger = logger;
        }

        #endregion

        #region Actions

        [HttpGet]
        public string Get()
        {
            try
            {
                logger.LogInformation("TotalmediaPOCApi start");
            }
            catch (Exception ex)
            {
                logger.LogInformation(ex, ex.Message);
                return "TotalmediaPOCApi fail to start";
            }

            return "TotalmediaPOCApi is running ...";
        }

        #endregion
    }
}
