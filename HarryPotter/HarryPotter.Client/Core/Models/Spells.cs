using System.Text.Json.Serialization;

namespace HarryPotter.Server.Models
{
    public class Spells
    {
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("name")]
        public decimal? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
