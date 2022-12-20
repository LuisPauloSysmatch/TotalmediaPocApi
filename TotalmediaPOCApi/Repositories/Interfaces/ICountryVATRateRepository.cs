using System.Threading.Tasks;
using TotalmediaPOCApi.Models;

namespace TotalmediaPOCApi.Repositories.Interfaces
{
    /// <summary>
    /// Interface for country VAT rate repository
    /// </summary>
    public interface ICountryVATRateRepository
    {
        /// <summary>
        /// Get country VAT rate list
        /// </summary>
        /// <returns>ApiResponse obj with country VAT rate list</returns>
        Task<ApiResponse> GetCountryVATRatesAsync();
    }
}
