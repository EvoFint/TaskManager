using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Backend.Models;
using TaskManager.Backend.Models.Dto;
using TaskManager.Backend.Services;

namespace TaskManager.Backend.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController:Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        public async Task<string> CreateTask(TaskModel task) => await _taskService.CreateNewTask(task);
    }
}