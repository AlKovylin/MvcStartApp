using System.Threading.Tasks;

namespace MvcStartApp.Models.Db
{
    public interface IRequestsRepository
    {
        Task AddRequest(string url);
        Task<Request[]> GetRequest();
    }
}