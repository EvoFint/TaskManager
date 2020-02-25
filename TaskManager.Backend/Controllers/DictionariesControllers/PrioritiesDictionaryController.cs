using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Backend.Models.Dto;
using TaskManager.Backend.Services;

namespace TaskManager.Backend.Controllers.DictionariesControllers
{
    [Route("api/dictionaries")]
    [ApiController]
    public class PrioritiesDictionaryController : Controller
    {
        private readonly IPrioritiesService _prioritiesService;
        
        public PrioritiesDictionaryController(IPrioritiesService prioritiesService)
        {
            _prioritiesService = prioritiesService;
        }

        [HttpGet, Route("priorities")]
        public async Task<PriorityDto[]> GetTasksPriorities(string token) => await _prioritiesService.GetAll();
    }
}