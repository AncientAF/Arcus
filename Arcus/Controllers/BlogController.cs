using Arcus.Models;
using Arcus.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Arcus.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
           this.blogRepository = blogRepository;
        }

        #region Старый методы с boilerplate
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        //{
        //    try
        //    {
        //        var posts = await this.blogRepository.GetPosts();

        //        return Ok(posts);

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<Post>> GetPost(int id)
        //{
        //    try
        //    {
        //        var post = await this.blogRepository.GetPost(id);


        //        if (post == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(post);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<IEnumerable<Category>>> GetPostCategory(int id)
        //{
        //    try
        //    {
        //        var categories = await this.blogRepository.GetPostCategory(id);


        //        if (categories == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(categories);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        //{
        //    try
        //    {
        //        var categories = await this.blogRepository.GetCategories();


        //        if (categories == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(categories);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<IEnumerable<Post>>> GetPostsByCategory(int id)
        //{
        //    try
        //    {
        //        var posts = await this.blogRepository.GetPostsByCategory(id);


        //        if (posts == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(posts);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<IEnumerable<Post>>> GetPostTags(int id)
        //{
        //    try
        //    {
        //        var tags = await this.blogRepository.GetPostTags(id);


        //        if (tags == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(tags);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<IEnumerable<Post>>> GetPostComments(int id)
        //{
        //    try
        //    {
        //        var comments = await this.blogRepository.PostComments(id);


        //        if (comments == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            return Ok(comments);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        //{
        //    try
        //    {
        //        var tags = await this.blogRepository.GetTags();

        //        return Ok(tags);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                        "Error retrieving data from the database");

        //    }
        //}
        #endregion
        #region Get методы
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            return await GetResponseFromRepo<IEnumerable<Post>>(await this.blogRepository.GetPosts());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            return await GetResponseFromRepo<Post>(await this.blogRepository.GetPost(id));
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetPostCategory(int id)
        {
            return await GetResponseFromRepo<IEnumerable<Category>>(await this.blogRepository.GetPostCategory(id));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await GetResponseFromRepo<IEnumerable<Category>>(await this.blogRepository.GetCategories());
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Post>>> GetPostsByCategory(int id)
        {
            return await GetResponseFromRepo<IEnumerable<Post>>(await this.blogRepository.GetPostsByCategory(id));
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Tag>>> GetPostTags(int id)
        {
            return await GetResponseFromRepo<IEnumerable<Tag>>(await this.blogRepository.GetPostTags(id));
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<PostComment>>> GetPostComments(int id)
        {
            return await GetResponseFromRepo<IEnumerable<PostComment>>(await this.blogRepository.GetPostComments(id));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tag>>> GetTags()
        {
            return await GetResponseFromRepo<IEnumerable<Tag>>(await this.blogRepository.GetTags());
        }
        
        #endregion
        #region Post методы
        [HttpPost]
        public async Task<ActionResult<int>> AddPost(string title, Boolean isPublished, string Context)
        {
            var newPost = new Post() {
                Title = title,
                IsPublished = isPublished,
                Context = Context
                };
            return CreatedAtAction(nameof(AddPost), await GetResponseFromRepo<int>(await this.blogRepository.Add<Post>(newPost)));
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddTag(string title)
        {
            var newTag = new Tag()
            {
                Title = title
            };
            return CreatedAtAction(nameof(AddPost), await GetResponseFromRepo<int>(await this.blogRepository.Add<Tag>(newTag)));
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddCategory(string title)
        {
            var newCategory = new Category()
            {
                Title = title
            };
            return CreatedAtAction(nameof(AddPost), await GetResponseFromRepo<int>(await this.blogRepository.Add<Category>(newCategory)));
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddPostTag(int postId, int tagId)
        {
            var newPostTag = new PostTag()
            {
                PostId = postId,
                TagId = tagId
            };
            return CreatedAtAction(nameof(AddPost), await GetResponseFromRepo<int>(await this.blogRepository.Add<PostTag>(newPostTag)));
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddPostCategory(int postId, int categoryId)
        {
            var newPostCategory = new PostCategory()
            {
                PostId = postId,
                CategoryId = categoryId
            };
            return CreatedAtAction(nameof(AddPost), await GetResponseFromRepo<int>(await this.blogRepository.Add<PostCategory>(newPostCategory)));
        }
        [HttpPost]
        public async Task<ActionResult<int>> AddPostComment(int postId, string content, Boolean isPublished)
        {
            var newPostComment = new PostComment()
            {
                PostId = postId,
                Content = content,
                Published = isPublished
            };
            return CreatedAtAction(nameof(AddPost), await GetResponseFromRepo<int>(await this.blogRepository.Add<PostComment>(newPostComment)));
        }

        #endregion
        private async Task<ActionResult<T>> GetResponseFromRepo<T>(T response) // Метод для проверки ответа от базы данных
        {
            try
            {
                if (response == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(response);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }


    }
}
