using Newtonsoft.Json;
using TaskManager.Backend.Models.DictionariesModels;

namespace TaskManager.Backend.Models.Dto
{
    public class PriorityDto
    {
        [JsonProperty("id")]
        private int Id { get; }
        
        [JsonProperty("name")]
        private string Name { get; }

        public PriorityDto(PrioritiesDictionary item)
        {
            Id = item.Id;
            Name = item.Name;
        }
        
        public static PriorityDto FromDocument(PrioritiesDictionary doc) => new PriorityDto(doc);
    }
}