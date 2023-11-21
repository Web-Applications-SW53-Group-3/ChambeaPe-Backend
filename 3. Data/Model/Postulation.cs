namespace _3._Data.Model
{
    public class Postulation : ModelBase
    {
        public int WorkerId { get; set; }
        public virtual Worker Worker { get; set; } = null!;
        public int PostId { get; set; }
        public virtual Post Post { get; set; } = null!;
    }
}