using System.Threading.Tasks;
using TaskManager.Backend.Models.Dto;

namespace TaskManager.Backend.Services
{
    public interface IPrioritiesService
    {
        Task<PriorityDto[]> GetAll();
    }
}