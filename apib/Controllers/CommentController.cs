namespace apib.Controllers;
using apib.Data;
using apib.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;


    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public CommentsController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var comments = await _context.Comments.ToListAsync();
            return Ok(comments);
        }

        [HttpGet("{commentId:int}")]
        public async Task<IActionResult> Get(int commentId)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.CommentId == commentId);

            if (comment == null)
                return BadRequest("Invalid CommentId");

            return Ok(comment);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { commentId = comment.CommentId }, comment);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int commentId, Comment updatedComment)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.CommentId == commentId);

            if (comment == null)
                return BadRequest("Invalid id");

            comment.Text = updatedComment.Text;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int commentId)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.CommentId == commentId);

            if (comment == null)
                return BadRequest("Invalid id");

            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
