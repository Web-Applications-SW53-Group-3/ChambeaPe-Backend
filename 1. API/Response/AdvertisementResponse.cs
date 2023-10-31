namespace _1._API.Response
{
    public class AdvertisementResponse
    {
        public string Category { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public string PictureUrl { get; set; } = null!;
    }
}