using Arcus.Entities;
using Arcus_backend.Entities.DTOs;

namespace Arcus_backend.Extensions
{
    public static class Extensions
    {
        public static PostWithTags ConvertToPostWithTags(this Post post, IEnumerable<Tag> tags)
        {
            return  new PostWithTags()
            {
                Title = post.Title,
                Context = post.Context,
                Author = post.Author,
                DateCreated = post.DateCreated,
                DatePublished = post.DatePublished, 
                DateUpdated = post.DateUpdated, 
                Id = post.Id,
                IsPublished = post.IsPublished,
                MetaTitle = post.MetaTitle,
                Tags = tags,
                ImagePath = post.ImagePath,
            };
            
        }
    }
}
