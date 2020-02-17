using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager_API.Models.DictionariesModels
{
    [Table("Statuses")]
    public class StatusesDictionary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("status_name")]
        public string Name { get; set; }
    }
}