using ATAPIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATAPIC.Services
{
    public class MockSocialService : ISocialService
    {
        public async Task<List<SocialPost>> GetPostsAsync(string platform, string search, int page)
        {
            var posts = new List<SocialPost>
            {
new SocialPost
{
    Author = "ATAPIC LinkedIn",
    Content = "Excited to launch our new product! #ProductLaunch #Startup #Innovation",
    Platform = "LinkedIn",
    ImageUrl = "/img/linkedin.jpg", // Image inside wwwroot/img/
    PostLink = "https://www.linkedin.com/company/atapic/posts/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
    Likes = 102,
    Comments = 22,
    Shares = 23
},

new SocialPost {
    Author = "NAWIN Instagram",
    Content = "Beautiful sunset from my run! #Fitness #MorningRun",
    Platform = "Instagram",
    ImageUrl = "/img/instagram-post.jpg",
    PostLink = "https://www.instagram.com/p/DL-PMFtMinX/",
    PostedDate = DateTime.Now.AddDays(-4),
    Likes = 89,
    Comments = 12,
    Shares = 5
},


new SocialPost
{
    Author = "ATAPIC LinkedIn",
    Content = "Excited to launch our new product! #ProductLaunch #Startup #Innovation",
    Platform = "LinkedIn",
    ImageUrl = "/img/linkedin.jpg", // Image inside wwwroot/img/
    PostLink = "https://www.linkedin.com/company/atapic/posts/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 229,
    Comments = 42,
    Shares = 18
},

new SocialPost
{
    Author = "ATAPIC LinkedIn",
    Content = "Excited to launch our new product! #ProductLaunch #Startup #Innovation",
    Platform = "LinkedIn",
    ImageUrl = "/img/linkedin.jpg", // Image inside wwwroot/img/
    PostLink = "https://www.linkedin.com/company/atapic/posts/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost
{
    Author = "ATAPIC LinkedIn",
    Content = "Excited to launch our new product! #ProductLaunch #Startup #Innovation",
    Platform = "LinkedIn",
    ImageUrl = "/img/linkedin.jpg", // Image inside wwwroot/img/
    PostLink = "https://www.linkedin.com/company/atapic/posts/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Instagram",
    Content = "Beautiful sunset from my run! #Fitness #MorningRun", Platform = "Instagram",
    ImageUrl = "/img/WhatsApp Video 2025-07-21 at 16.18.01.mp4",PostLink = "https://www.instagram.com/p/DL-PMFtMinX/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Instagram",
    Content = "Beautiful sunset from my run! #Fitness #MorningRun", Platform = "Instagram",
    ImageUrl = "/img/WhatsApp Image 2025-07-21 at 16.18.48.jpg",PostLink = "https://www.instagram.com/p/DL-PMFtMinX/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Instagram",
    Content = "Beautiful sunset from my run! #Fitness #MorningRun", Platform = "Instagram",
    ImageUrl = "/img/WhatsApp Image 2025-07-21 at 16.18.48.jpg",PostLink = "https://www.instagram.com/p/DL-PMFtMinX/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Instagram",
    Content = "Beautiful sunset from my run! #Fitness #MorningRun", Platform = "Instagram",
    ImageUrl = "/img/WhatsApp Image 2025-07-21 at 16.18.48.jpg",PostLink = "https://www.instagram.com/p/DL-PMFtMinX/", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Twitter",
    Content = "The future of AI is exciting 🚀 #AI #Tech",
    Platform = "Twitter",
    ImageUrl = "/img/twitter.jpg",
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Twitter",
    Content = "The future of AI is exciting 🚀 #AI #Tech",
    Platform = "Twitter",
    ImageUrl = "/img/twitter.jpg",
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC Twitter",
    Content = "The future of AI is exciting 🚀 #AI #Tech",
    Platform = "Twitter",
    ImageUrl = "/img/twitter.jpg",
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},

new SocialPost {
    Author = "ATAPIC YouTube",
    Content = "Beautiful sunset from my run! #Fitness #MorningRun", Platform = "YouTube",
    ImageUrl = "/img/WhatsApp Video 2025-07-21 at 16.18.01.mp4",PostLink = "https://www.youtube.com/@ATAPIC", // ✅ external post link
    PostedDate = DateTime.Now.AddDays(-4),
     Likes = 89,
    Comments = 12,
    Shares = 5
},




            };



            if (platform != "All")
                posts = posts.Where(p => p.Platform == platform).ToList();

            if (!string.IsNullOrEmpty(search))
                posts = posts.Where(p => p.Content.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();

            return await Task.FromResult(posts);
        }
    }
}
