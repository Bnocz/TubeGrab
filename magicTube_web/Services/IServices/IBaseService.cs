using magicTube_web.Models;
using magicTube_web.Models.Models;

namespace magicTube_web.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }

        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
