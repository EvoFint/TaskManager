using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManager.Backend.Models.Context;
using TaskManager.Backend.Models.Dto;

namespace TaskManager.Backend.Services
{
    public class TypesService : ITypesService
    {
        TaskManagerAppContext db = new TaskManagerAppContext();
        public async Task<TypeDto[]> GetAll()
        {
            var typesDictionary = await db.TypesDictionaries.ToListAsync();
            var dtos = typesDictionary.Select(TypeDto.FromDocument).ToArray();
            return dtos;
        }
    }
}