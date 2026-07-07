using System.Text.Json;
using HarryPotter.Client.Core.Models;

namespace HarryPotter.Client.Core.Services
{
    public class HarryPotterService
    {
        private readonly HttpClient _httpClient;

        private const string BaseAddress = "harrypotter/";

        public HarryPotterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Character>> GetCharactersAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{BaseAddress}characters");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            List<Character>? characters = JsonSerializer.Deserialize<List<Character>>(json);

            return characters ?? new List<Character>();
        }

        public async Task<List<Spells>> GetSpellsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{BaseAddress}spells");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            List<Spells>? spells = JsonSerializer.Deserialize<List<Spells>>(json);

            return spells ?? new List<Spells>();
        }

    }
}
