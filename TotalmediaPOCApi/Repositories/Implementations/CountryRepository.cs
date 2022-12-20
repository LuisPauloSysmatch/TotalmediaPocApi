using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;
using TotalmediaPOCApi.Models;
using TotalmediaPOCApi.Repositories.Interfaces;

namespace TotalmediaPOCApi.Repositories.Implementations
{
    /// <summary>
    /// Repository for countries
    /// </summary>
    public class CountryRepository : ICountryRepository
    {
        #region Core

        private readonly TotalmediaPOCDbContext totalmediaPOCDbContext;
        private readonly ILogger<CountryRepository> logger;

        public CountryRepository(TotalmediaPOCDbContext totalmediaPOCDbContext, ILogger<CountryRepository> logger)
        {
            this.totalmediaPOCDbContext = totalmediaPOCDbContext;
            this.logger = logger;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Get country list
        /// </summary>
        /// <returns>ApiResponse obj with country list</returns>
        public async Task<ApiResponse> GetCountriesAsync()
        {
            var apiResponse = new ApiResponse();

            try
            {
                apiResponse.Data = await totalmediaPOCDbContext.Countries.OrderBy(i => i.CountryName).ToListAsync();
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
