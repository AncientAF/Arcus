using System.ComponentModel.DataAnnotations.Schema;

namespace Arcus.Models
{
    public class PostComment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string? Title { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Content { get; set; }


    }
}
