using Newtonsoft.Json;

namespace TaskManager.Backend.Models.Dto
{
    public class TaskDto
    {
        [JsonProperty("id")]
        private int Id { get; }
        
        [JsonProperty("boardId")]
        private int BoardId { get; }
        
        [JsonProperty("name")]
        private string Name { get; }
        
        [JsonProperty("parentItemId")]
        private int? ParentItemId { get; }
        
        [JsonProperty("typeId")]
        private int TypeId { get; }
        
        [JsonProperty("description")]
        private string Description { get; }
        
        [JsonProperty("statusId")]
        private int StatusId { get; }
        
        [JsonProperty("storyPoints")]
        private int StoryPoints { get; }

        [JsonProperty("priorityId")]
        private int PriorityId { get; }
        
        public TaskDto(TaskModel item)
        {
            Id = item.Id;
            BoardId = item.BoardId;
            Name = item.Name;
            ParentItemId = item.ParentItemId;
            TypeId = item.TypeId;
            Description = item.Description;
            StatusId = item.StatusId;
            StoryPoints = item.StoryPoint;
            PriorityId = item.PriorityId;
        }
        
        public static TaskDto FromDocument(TaskModel doc) => new TaskDto(doc);
    }
}