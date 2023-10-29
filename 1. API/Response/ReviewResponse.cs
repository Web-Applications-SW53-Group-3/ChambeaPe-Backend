namespace _1._API.Response
{
    public class ReviewResponse
    {
        public int EmployerId { get; set; }

        public int WorkerId { get; set; }

        public string Description { get; set; } = null!;

        public DateTime Date { get; set; }

        public int SentById { get; set; }
    }
}
