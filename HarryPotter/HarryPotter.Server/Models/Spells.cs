using System.Text.Json.Serialization;

namespace HarryPotter.Server.Models
{
    public class Spell
    {
        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
