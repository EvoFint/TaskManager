using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager_API.Models.DictionariesModels;

namespace TaskManager_API.Models
{
    public class TaskManagerAppContext : DbContext
    {
        public DbSet<StatusesDictionary> StatusesDictionaries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=task_manager_db;Username=postgres;Password=Evofint8146");
        }
    }
}