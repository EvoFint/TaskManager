using System.Threading.Tasks;
using TaskManager.Backend.Models;
using TaskManager.Backend.Models.Context;

namespace TaskManager.Backend.Services
{
    public class TaskService : ITaskService
    {
        TaskManagerAppContext db = new TaskManagerAppContext();
        
        public async Task<string> CreateNewTask(TaskModel task)
        {
            db.Tasks.Add(task);
            await db.SaveChangesAsync();
            return "Ok";
        }
    }
}