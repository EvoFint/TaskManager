using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Backend.Models.Context;
using TaskManager.Backend.Models.DictionariesModels;
using TaskManager.Backend.Models.Dto;

namespace TaskManager.Backend.Services
{
    public class StatusesService : IStatusesService
    {
        TaskManagerAppContext db = new TaskManagerAppContext();
        public async Task<StatusesListDto> GetAll()
        {
            var statusesDictionary = await db.StatusesDictionaries.ToListAsync();
            var dto = statusesDictionary.Select(StatusDto.FromDocument);
            return new StatusesListDto{Items = dto.ToArray()};
        }
    }
}