using Microsoft.EntityFrameworkCore;
using TaskManager.Backend.Models.DictionariesModels;

namespace TaskManager.Backend.Models.Context
{
    public class TaskManagerAppContext : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<StatusesDictionary> StatusesDictionaries { get; set; }
        public DbSet<TypesDictionary> TypesDictionaries { get; set; }
        public DbSet<PrioritiesDictionary> PrioritiesDictionaries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=task_manager_db;Username=postgres;Password=Evofint8146");
        }
    }
}