using System.Threading.Tasks;

namespace TaskManager.Backend.Services
{
    public interface IStatusesService
    {
        Task GetAll();
    }
}