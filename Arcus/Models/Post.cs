namespace Arcus.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string AuthorId { get; set; }
        public string ParentId { get; set; }
        public string DatePublished { get; set; }
        public string DateUpdated { get; set; }
        public string DateCreated { get; set; }
        public bool IsPublished { get; set; }
        public string Context { get; set; }


    }
}
