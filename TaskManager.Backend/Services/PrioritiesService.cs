using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Backend.Models.Context;
using TaskManager.Backend.Models.Dto;

namespace TaskManager.Backend.Services
{
    public class PrioritiesService : IPrioritiesService
    {
        TaskManagerAppContext db = new TaskManagerAppContext();
        public async Task<PriorityDto[]> GetAll()
        {
            var prioritiesDictionary = await db.PrioritiesDictionaries.ToListAsync();
            var dtos = prioritiesDictionary.Select(PriorityDto.FromDocument).ToArray();
            return dtos;
        }
    }
}