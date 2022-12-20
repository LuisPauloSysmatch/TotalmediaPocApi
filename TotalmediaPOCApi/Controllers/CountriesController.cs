using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TotalmediaPOCApi.Repositories.Interfaces;

namespace TotalmediaPOCApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountriesController : ControllerBase
    {
        #region Core

        private readonly ICountryRepository countryRepository;
        private readonly ILogger<CountriesController> logger;

        public CountriesController(ICountryRepository countryRepository, ILogger<CountriesController> logger)
        {
            this.countryRepository = countryRepository;
            this.logger = logger;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Get countries
        /// </summary>
        /// <returns>ApiResponse obj</returns>
        [HttpGet]
        public async Task<ActionResult> GetCountries()
        {
            logger.LogInformation("GetCountries start");
            
            // execute request
            var result = await countryRepository.GetCountriesAsync();

            if (result.HasError)
            {   // error
                logger.LogError("GetCountries end with error" + result.ErrorMessage);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }

            // success
            logger.LogInformation("GetCountries end without error");
            return Ok(result);
        }

        #endregion
    }
}
