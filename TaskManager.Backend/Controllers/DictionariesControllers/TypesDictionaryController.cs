using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Backend.Models.Dto;
using TaskManager.Backend.Services;

namespace TaskManager.Backend.Controllers.DictionariesControllers
{
    [Route("api/dictionaries")]
    [ApiController]
    public class TypesDictionaryController : Controller
    {
        private readonly ITypesService _typesService;

        public TypesDictionaryController(ITypesService typesService)
        {
            _typesService = typesService;
        }

        [HttpGet, Route("types")]
        public async Task<TypeDto[]> GetTasksTypes(string token) => await _typesService.GetAll();
    }
}