using System.Threading.Tasks;
using TaskManager.Backend.Models;

namespace TaskManager.Backend.Services
{
    public interface ITaskService
    {
        Task<TaskModel> CreateNewTask(TaskModel task);
    }
}