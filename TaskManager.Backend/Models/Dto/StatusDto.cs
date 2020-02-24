using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TaskManager.Backend.Models.DictionariesModels;

namespace TaskManager.Backend.Models.Dto
{
    public class StatusDto
    {
        [JsonProperty("id")] 
        private int Id { get; }
        
        [JsonProperty("name")]
        private string Name { get; }

        public StatusDto(StatusesDictionary item)
        {
            Id = item.Id;
            Name = item.Name;
        }
        public static StatusDto FromDocument(StatusesDictionary doc) => new StatusDto(doc);
    }
}