using StarWarsPlanetNames.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Services
{
    public class PeopleObjClient
    {
        private readonly HttpClient _client;

        public PeopleObjClient(HttpClient client)
        {
            _client = client;
        }
        public async Task<PeopleModel> GetPeopleInfo(string page ="1")
        {
            var results = await _client.GetAsync($"people/?page={page}");
            if (results.IsSuccessStatusCode)
            {
                var stringContent = await results.Content.ReadAsStringAsync();

                var toCamelCase = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                var obj = JsonSerializer.Deserialize<PeopleModel>(stringContent, toCamelCase);
                return obj;

            }
            else
            {
                throw new HttpRequestException("noones here maybe its Alderaan");

            }


        }

    }
}
