using Newtonsoft.Json;

namespace Country.Models
{
    public class CountryInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }
}
