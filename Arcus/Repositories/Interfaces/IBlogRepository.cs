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
        Task<IEnumerable<PostComment>> GetPostComments(int id);
        Task<IEnumerable<Tag>> GetPostTags(int id);
        Task<IEnumerable<Tag>> GetTags();
        Task<int> Add<T>(T newObj);
        //Task<int> AddTag(Tag newTag);
        //Task<int> AddCategory(Category newCategory);
        //Task<int> AddComment(PostComment newPostComments);
        //Task<int> AddTagToPost(PostTag newPostTag);
        //Task<int> AddCategoryToPost(PostCategory newPostCategory);

    }
}
