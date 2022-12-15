namespace Enterprise_Applications_Development_1_CA3.wwwroot.Models
{
    public class DaysService : IDaysService
    {

        private readonly HttpClient _httpClient;
        const string _url = "curl -H 'X-Api-Key: 6887a9cd95ce4274bf0cc427981215fc' 'https://www.daysoftheyear.com/api/v1/date/'";
        const string _Endpoint = "today/";
        //const string -Host = "https://www.daysoftheyear.com/api/v1/date/2022/01/";
        const string _key = "6887a9cd95ce4274bf0cc427981215fc";

        public DaysService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<list<UsersDays>> GetDays()
        {
            ConfigureClient();
            var response = await _httpClient.GetAsync(_Endpoint);
            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
        }



        private void ConfigureHttpClient()
        {
            _httpClient.BaseAddress = new Uri(_url);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", _key);
        }
        {
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", _key);
            _httpClient.BaseAddress = new Uri(_url);
            
        }
    }
}
