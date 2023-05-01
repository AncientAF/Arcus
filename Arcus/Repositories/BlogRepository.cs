using Arcus.Data;
using Arcus.Models;
using Arcus.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Arcus.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ArcusDbContext _arcusDbContext;
        public BlogRepository(ArcusDbContext arcusDbContext)
        {
            this._arcusDbContext = arcusDbContext;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await this._arcusDbContext.Categories.ToListAsync();

            return categories;
        }

        public async Task<IEnumerable<Category>> GetPostCategory(int id)
        {
            var category = await this._arcusDbContext.PostCategories.Where(c => c.PostId == id).Select(c => c.Category).ToListAsync();

            return category;
        }

        public async Task<Post> GetPost(int id)
        {
            var post = await this._arcusDbContext.Posts.SingleOrDefaultAsync(p => p.Id == id);

            return post;
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = await this._arcusDbContext.Posts.ToListAsync();

            return posts;
        }

        public async Task<IEnumerable<Post>> GetPostsByCategory(int id)
        {
            var posts = await this._arcusDbContext.PostCategories.Where(c => c.CategoryId == id).Select(p => p.Post).ToListAsync();

            return posts;
        }

        public async Task<IEnumerable<Tag>> GetPostTags(int id)
        {
            var tags = await this._arcusDbContext.PostTags.Where(t => t.PostId == id).Select(t => t.Tag).ToListAsync();

            return tags;
        }

        public async Task<IEnumerable<PostComment>> PostComments(int id)
        {
            var comments = await this._arcusDbContext.PostComments.Where(c => c.PostId == id).ToListAsync();

            return comments;
        }
    }
}
