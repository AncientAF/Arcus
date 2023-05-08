using Arcus.Entities;

namespace Arcus_backend.Entities.DTOs
{
    public class PostWithTags : Post
    {
        public IEnumerable<Tag> Tags { get; set; }
    }
}
