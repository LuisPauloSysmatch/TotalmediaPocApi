using System.Threading.Tasks;
using TotalmediaPOCApi.Models;

namespace TotalmediaPOCApi.Repositories.Interfaces
{
    /// <summary>
    /// Interface for country repository
    /// </summary>
    public interface ICountryRepository
    {
        /// <summary>
        /// Get country list
        /// </summary>
        /// <returns>ApiResponse obj with country list</returns>
        Task<ApiResponse> GetCountriesAsync();
    }
}
