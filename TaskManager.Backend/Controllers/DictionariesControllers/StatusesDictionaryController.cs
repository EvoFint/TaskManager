using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager_API.Models;

namespace TaskManager_API.Controllers.DictionariesControllers
{
    [Route("api/dictionaries")]
    [ApiController]
    public class StatusesDictionaryController : Controller
    {
        [HttpGet("statuses")]
        public async Task<IActionResult> GetTasksStatuses(string token)
        {
            using (TaskManagerAppContext db = new TaskManagerAppContext())
            {
                var statusesDictionary = await db.StatusesDictionaries.ToListAsync();
                return Json(statusesDictionary.Select(sd => new {id = sd.Id, name = sd.Name}));
            }
        }
    }
}