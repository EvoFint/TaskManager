using System.Text.Json.Serialization;

namespace TaskManager.Backend.Models.DTO
{
    public class StatusesDto
    {
        [JsonPropertyName("id")] 
        private int Id { get; }
        
        [JsonPropertyName("name")]
        private string Name { get; }

        public StatusesDto(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}