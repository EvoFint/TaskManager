using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Backend.Models.Context;
using TaskManager.Backend.Models.DictionariesModels;
using TaskManager.Backend.Models.Dto;
using TaskManager.Backend.Services;

namespace TaskManager.Backend.Controllers.DictionariesControllers
{
    [Route("api/dictionaries")]
    [ApiController]
    public class StatusesDictionaryController : Controller
    {
        private readonly IStatusesService _statusesService;

        public StatusesDictionaryController(IStatusesService statusesService)
        {
            _statusesService = statusesService;
        }

        [HttpGet, Route("statuses")]
        public async Task<StatusesListDto> GetTasksStatuses(string token) => await _statusesService.GetAll();
    }
}