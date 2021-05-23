using System.Net.Http;
using System.Threading.Tasks;
using TitleInfoClient.DTOs;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

namespace TitleInfoClient.DataServices
{
    public class TitleInfoDataServiceGraphQL : ITitlesDataService
    {
        private readonly HttpClient _httpClient;
        public TitleInfoDataServiceGraphQL(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<TitleInfoSearchDTO[]> GetAllTitles()
        {
            var queryObject = new
            {
                query = @"{titles { titleId titleName storyLines { description }}}",
                variables = new { }
            };

            string json = JsonSerializer.Serialize(queryObject);

            var titlesQuery = new StringContent(json, Encoding.UTF8, "application/json");

            //var titlesQuery = new StringContent(JsonSerializer.Serialize(queryObject), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("graphql", titlesQuery);

            if (response.IsSuccessStatusCode)
            {
                var gqlData = await JsonSerializer.DeserializeAsync<GqlData>(await response.Content.ReadAsStreamAsync());

                return gqlData.Data.Titles;

            }
            return null;//TODO:remove and add error handling  
        }
    }
}
