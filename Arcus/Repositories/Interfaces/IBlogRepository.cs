using Arcus.Models;

namespace Arcus.Repositories.Interfaces
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Post>> GetPosts();
        Task<IEnumerable<Category>> GetCategories();
        Task<Post> GetPost(int id);
        Task<IEnumerable<Category>> GetPostCategory(int id);
        Task<IEnumerable<Post>> GetPostsByCategory(int id);
        Task<IEnumerable<PostComment>> PostComments(int id);
        Task<IEnumerable<Tag>> GetPostTags(int id);
    }
}
