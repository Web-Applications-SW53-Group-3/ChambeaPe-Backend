namespace _1._API.Response
{
    public class PostResponse
    {
        public int PostId { get; set; }

        public int EmployerId { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Subtitle { get; set; } = null!;

        public string ImgUrl { get; set; } = null!;
  
    }
}
