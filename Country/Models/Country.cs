namespace Country.Models
{
    public class CountryInfo
    {
        public string Name { get; set; }
        public string Alpha2Code { get; set; }
        public string Capital { get; set; }
        public int CallingCodes { get; set; }
        public string FlagUrl { get; set; }
        public string Timezones { get; set; }

        public CountryInfo(string name, string alpha2Code, string capital, int callingCodes, string flagUrl, string timezones)
        {
            Name = name;
            Alpha2Code = alpha2Code;
            Capital = capital;
            CallingCodes = callingCodes;
            FlagUrl = flagUrl;
            Timezones = timezones;
        }
    }
}
