using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using TotalmediaPOCApi.Models;
using TotalmediaPOCApi.Repositories.Interfaces;

namespace TotalmediaPOCApi.Repositories.Implementations
{
    /// <summary>
    /// Repository for country VAT rates
    /// </summary>
    public class CountryVATRateRepository : ICountryVATRateRepository
    {
        #region Core

        private readonly TotalmediaPOCDbContext totalmediaPOCDbContext;
        private readonly ILogger<CountryRepository> logger;

        public CountryVATRateRepository(TotalmediaPOCDbContext totalmediaPOCDbContext, ILogger<CountryRepository> logger)
        {
            this.totalmediaPOCDbContext = totalmediaPOCDbContext;
            this.logger = logger;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Get country VAT rate list
        /// </summary>
        /// <returns>ApiResponse obj with country VAT rate list</returns>
        public async Task<ApiResponse> GetCountryVATRatesAsync()
        {
            var apiResponse = new ApiResponse();

            try
            {
                apiResponse.Data = await totalmediaPOCDbContext.CountryVATRates.ToListAsync();
                apiResponse.HasError = false;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                apiResponse.HasError = true;
                apiResponse.ErrorMessage = ex.Message;
                apiResponse.Data = null;
            }

            return apiResponse;
        }

        #endregion

    }
}
