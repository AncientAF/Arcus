using Arcus.Data;
using Arcus.Models;
using Arcus.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Arcus.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ArcusDbContext _arcusDbContext;
        public BlogRepository(ArcusDbContext arcusDbContext)
        {
            this._arcusDbContext = arcusDbContext;
        }
        #region Get методы
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


        public async Task<IEnumerable<PostComment>> GetPostComments(int id)
        {
            var comments = await this._arcusDbContext.PostComments.Where(c => c.PostId == id).ToListAsync();

            return comments;
        }

        public async Task<IEnumerable<Tag>> GetTags()
        {
            var tags = await this._arcusDbContext.Tags.ToListAsync();

            return tags;
        }
        #endregion
        #region Add методы
        public async Task<int> Add<T>(T newObj)
        {
            try
            {
                await this._arcusDbContext.AddAsync(newObj);
                return await this._arcusDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw (new DataException());
            }
        }

        //public async Task<int> AddTag(Tag newTag)
        //{
        //    try
        //    {
        //        await this._arcusDbContext.AddAsync(newTag);
        //        return await this._arcusDbContext.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {

        //        throw (new DataException());
        //    }
        //}

        //public async Task<int> AddCategory(Category newCategory)
        //{
        //    try
        //    {
        //        await this._arcusDbContext.AddAsync(newCategory);
        //        return await this._arcusDbContext.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {

        //        throw (new DataException());
        //    }
        //}

        //public async Task<int> AddComment(PostComment newPostComments)
        //{
        //    try
        //    {
        //        await this._arcusDbContext.AddAsync(newPostComments);
        //        return await this._arcusDbContext.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {

        //        throw (new DataException());
        //    }
        //}

        //public async Task<int> AddTagToPost(PostTag newPostTag)
        //{
        //    try
        //    {
        //        await this._arcusDbContext.AddAsync(newPostTag);
        //        return await this._arcusDbContext.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {

        //        throw (new DataException());
        //    }
        //}

        //public async Task<int> AddCategoryToPost(PostCategory newPostCategory)
        //{
        //    try
        //    {
        //        await this._arcusDbContext.AddAsync(newTag);
        //        return await this._arcusDbContext.SaveChangesAsync();
        //    }
        //    catch (Exception)
        //    {

        //        throw (new DataException());
        //    }
        //}

        #endregion
    }
}
