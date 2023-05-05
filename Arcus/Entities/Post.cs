using System.ComponentModel.DataAnnotations.Schema;

namespace Arcus.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string? MetaTitle { get; set; }
        public User? Author { get; set; }
        public DateTime? DatePublished { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool IsPublished { get; set; }
        public string Context { get; set; }


    }
}
