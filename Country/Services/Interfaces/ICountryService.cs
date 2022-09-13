using Country.Controllers;
using Country.Models;

namespace Country.Services.Interfaces
{
    public interface ICountryService
    {
        Task<BaseResponse<CountryInfo>> GetCountryByName(GetCountryByNameRequest request);
        Task<BaseResponse<List<CountryInfo>>> GetCountryByArea(GetCountryByAreaRequest request);
    }
}
