using Arcus.Models;
using Arcus.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
        {
            try
            {
                var posts = await this.blogRepository.GetPosts();


                if (posts == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(posts);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Post>> GetPost(int id)
        {
            try
            {
                var post = await this.blogRepository.GetPost(id);


                if (post == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(post);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetPostCategory(int id)
        {
            try
            {
                var categories = await this.blogRepository.GetPostCategory(id);


                if (categories == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(categories);
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
