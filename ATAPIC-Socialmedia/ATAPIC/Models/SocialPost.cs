namespace ATAPIC.Models
{
    public class SocialPost
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public string Platform { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PostedDate { get; set; }
        public string PostLink { get; set; } // Add this property
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int Shares { get; set; }



    }
}
