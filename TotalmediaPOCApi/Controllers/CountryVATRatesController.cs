using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TotalmediaPOCApi.Repositories.Interfaces;

namespace TotalmediaPOCApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryVATRatesController : Controller
    {
        #region Core

        private readonly ICountryVATRateRepository countryVATRateRepository;
        private readonly ILogger<CountryVATRatesController> logger;

        public CountryVATRatesController(ICountryVATRateRepository countryVATRateRepository, ILogger<CountryVATRatesController> logger)
        {
            this.countryVATRateRepository = countryVATRateRepository;
            this.logger = logger;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Get countries VAT rates
        /// </summary>
        /// <returns>ApiResponse obj</returns>
        [HttpGet]
        public async Task<ActionResult> GetCountryVATRates()
        {
            logger.LogInformation("GetCountriesVATRates start");

            // execute request
            var result = await countryVATRateRepository.GetCountryVATRatesAsync();

            if (result.HasError)
            {   // error
                logger.LogError("GetCountriesVATRates end with error" + result.ErrorMessage);
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }

            // success
            logger.LogInformation("GetCountriesVATRates end without error");
            return Ok(result);
        }

        #endregion

    }
}
