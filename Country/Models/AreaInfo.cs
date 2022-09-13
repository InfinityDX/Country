namespace Country.Models
{
    public class AreaInfo
    {
        public string Region { get; set; }
        public string Timezone { get; set; }

        public AreaInfo(string region, string timezone)
        {
            Region = region;
            Timezone = timezone;
        }
    }
}
