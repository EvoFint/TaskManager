using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Backend.Models.DictionariesModels
{
    [Table("types")]
    public class TypesDictionary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("type_name")]
        public string Name { get; set; }
    }
}