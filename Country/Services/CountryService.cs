using Country.Controllers;
using Country.Models;
using Country.Services.Interfaces;
using System.Text.Json;

namespace Country.Services
{
    public class CountryService : ICountryService
    {
        HttpClient _httpClient = new HttpClient();
        public Task<BaseResponse<List<CountryInfo>>> GetCountryByArea(GetCountryByAreaRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<CountryInfo>> GetCountryByName(GetCountryByNameRequest request)
        {
            var response = await _httpClient.GetAsync($"https://restcountries.com/v2/name/{request.CountryByName}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                CountryInfo countryInfo = JsonSerializer.Deserialize<CountryInfo>(content.Substring(1,content.Length -2));
                return new BaseResponse<CountryInfo>(0, "Success", countryInfo);
            }

            return new BaseResponse<CountryInfo>(11, "Getting data from restcountries.com error!", new CountryInfo("", "", "", 0, "", ""));
        }
    }
}
