namespace Arcus.Models
{
    public class PostComment
    {
        public int Id { get; set; }
        public string PostId { get; set; }
        public string ParentId { get; set; }
        public string Title { get; set; }
        public bool Published { get; set; }
        public string PublishedAt { get; set; }
        public string CreatedAt { get; set; }
        public string Content { get; set; }


    }
}
