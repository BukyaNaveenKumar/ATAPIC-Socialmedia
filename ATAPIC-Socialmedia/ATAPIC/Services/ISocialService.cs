using ATAPIC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ATAPIC.Services
{
    public interface ISocialService
    {
        Task<List<SocialPost>> GetPostsAsync(string platform, string search, int page);
    }
}
