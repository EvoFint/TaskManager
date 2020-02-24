using Newtonsoft.Json;
using TaskManager.Backend.Models.DictionariesModels;

namespace TaskManager.Backend.Models.Dto
{
    public class TypeDto
    {
        [JsonProperty("id")]
        private int Id { get; }
        
        [JsonProperty("name")]
        private string Name { get; }

        public TypeDto(TypesDictionary item)
        {
            Id = item.Id;
            Name = item.Name;
        }
        
        public static TypeDto FromDocument(TypesDictionary doc) => new TypeDto(doc);
    }
}