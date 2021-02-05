using StarWarsPlanetNames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarWarsPlanetNames.Services
{
    public class PlanetObjClient : IPlanetObjClient
    {
        private readonly HttpClient _client;

        public PlanetObjClient(HttpClient client)
        {
            _client = client;
        }
        
        public async Task<PeoplePlanetCombinedModel> GetPlanetInfo(int page)
        {
            var results = await _client.GetAsync($"planets/?page={page}");
            if (results.IsSuccessStatusCode)
            {
                var stringContent = await results.Content.ReadAsStringAsync();

                var toCamelCase = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                var obj = JsonSerializer.Deserialize<PeoplePlanetCombinedModel>(stringContent, toCamelCase);
                return obj;
            
            }
            else
            {
                throw new HttpRequestException("no planets here my dude");

            }

        }
    }
}
