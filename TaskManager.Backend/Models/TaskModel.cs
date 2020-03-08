using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Backend.Models
{
    [Table("items")]
    public class TaskModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("board_id")]
        public int BoardId { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("parent_item_id")]
        public int ParentItemId { get; set; }
        
        [Column("type_id")]
        public int TypeId { get; set; }
        
        [Column("description")]
        public string Description { get; set; }
        
        [Column("status_id")]
        public int StatusId { get; set; }
        
        [Column("story_points")]
        public int StoryPoint { get; set; }
    }
}