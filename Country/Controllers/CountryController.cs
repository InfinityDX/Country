using Country.Models;
using Country.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Country.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryService _countryService;

        public CountryController(ILogger<CountryController> logger, ICountryService countryService)
        {
            _logger = logger;
            _countryService = countryService;
        }

        [HttpPost]
        [Route("GetCountryByName")]
        public async Task<BaseResponse<CountryInfo>> GetCountryByName([FromBody] GetCountryByNameRequest request)
        {
            return await _countryService.GetCountryByName(request);
        }

        [HttpPost]
        [Route("GetCountryByArea")]
        public async Task<BaseResponse<List<CountryInfo>>> GetCountryByArea([FromBody] GetCountryByAreaRequest request)
        {
            return await _countryService.GetCountryByArea(request);
        }

    }

    public class GetCountryByNameRequest
    {

        public string CountryByName { get; set; }

        public GetCountryByNameRequest(string countryByName)
        {
            CountryByName = countryByName;
        }
    }

    public class GetCountryByAreaRequest
    {
        public AreaInfo AreaInfo { get; set; }

        public GetCountryByAreaRequest(AreaInfo areaInfo)
        {
            AreaInfo = areaInfo;
        }
    }

}