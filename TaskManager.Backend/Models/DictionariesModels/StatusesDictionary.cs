using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Backend.Models.DictionariesModels
{
    [Table("statuses")]
    public class StatusesDictionary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("status_name")]
        public string Name { get; set; }
    }
}